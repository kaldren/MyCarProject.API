using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using Troshka.Infrastructure.Data;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = true;
});

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"))
    .EnableTokenAcquisitionToCallDownstreamApi()
    .AddMicrosoftGraph(builder.Configuration.GetSection("GraphApi"))
    .AddInMemoryTokenCaches();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowTroshkaSPA", policy =>
    {
        policy.WithOrigins(builder.Configuration.GetValue<string>("Troshka:SPAClient:Domain"))
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials();
    });
});

// ODATA
builder.Services.AddControllers().AddOData(opt => opt.Count().Filter().Expand().Select().OrderBy().SetMaxTop(10));

// Data
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDbContext<TroshkaDbContext>(options =>
{
    options.UseLazyLoadingProxies();
    options.UseSqlServer(builder.Configuration.GetConnectionString("TroshkaContext"));
    //options.UseNpgsql(builder.Configuration.GetValue<string>("ConnectionStrings:TroshkaContext"));
    //options.UseInMemoryDatabase("Troshka");
});

var app = builder.Build();

// migrate any database changes on startup (includes initial db creation)
using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<TroshkaDbContext>();
    dataContext.Database.EnsureDeleted();
    dataContext.Database.Migrate();
}

app.UseResponseCompression();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();

    app.UseMigrationsEndPoint();

    bool initData = builder.Configuration.GetValue<bool>("Troshka:Azure:Database:InitData");

    if (initData)
    {
        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var loggerFactory = services.GetRequiredService<ILoggerFactory>();

            var logger = loggerFactory.CreateLogger<ILogger>();

            logger.LogDebug("Seeding data...");
            var context = services.GetRequiredService<TroshkaDbContext>();
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();
            DbInitializer.Initialize(context, logger);
            logger.LogDebug("Seed data inserted successfully...");
        }
    }
}
else
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseExceptionHandler(exceptionHandlerApp =>
    {
        exceptionHandlerApp.Run(async context =>
        {
            var ex = context.Features.Get<IExceptionHandlerFeature>();
            if (ex != null)
            {
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Response.ContentType = Text.Plain;

                var loggerFactory = app.Services.GetRequiredService<ILoggerFactory>();

                var logger = loggerFactory.CreateLogger<ILogger>();

                logger.LogError($"{DateTime.UtcNow} {ex.Error.StackTrace}");

                var response = new
                {
                    message = "Oops! We're currently working on fixing this error.",
                    dateTimeUtc = DateTime.UtcNow,
                };

                await context.Response.WriteAsJsonAsync(response);
            }

        });
    });
}


app.UseCors(options => options.WithOrigins(builder.Configuration.GetValue<string>("Troshka:SPAClient:Domain")).AllowAnyMethod().AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.Run();