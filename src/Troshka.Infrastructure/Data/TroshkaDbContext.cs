using Microsoft.EntityFrameworkCore;
using Troshka.Domain.Entities.OwnerAggregate;
using Troshka.Domain.Entities.VehicleAggregate;

namespace Troshka.Infrastructure.Data
{
    public class TroshkaDbContext : DbContext
    {
        public TroshkaDbContext(DbContextOptions<TroshkaDbContext> options) : base(options)
        {
        }

        public DbSet<VehicleEntity> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<VehicleEntity>()
                .ToTable("Vehicles");

            modelBuilder
                .Entity<VehicleCategoryEntity>()
                .ToTable("Categories");

            modelBuilder
                .Entity<VehicleCategoryEntity>()
                .HasData(
                    new VehicleCategoryEntity { Name = "Cars" },
                    new VehicleCategoryEntity { Name = "Buses" },
                    new VehicleCategoryEntity { Name = "Motorcycles" },
                    new VehicleCategoryEntity { Name = "Trucks" },
                    new VehicleCategoryEntity { Name = "Caravans" },
                    new VehicleCategoryEntity { Name = "Boats" },
                    new VehicleCategoryEntity { Name = "Construction" },
                    new VehicleCategoryEntity { Name = "Agriciltural" }
                );

            modelBuilder
                .Entity<VehicleBrandEntity>()
                .ToTable("Brands");

            modelBuilder
                .Entity<VehicleBrandEntity>()
                .HasData(
                    new VehicleBrandEntity { Name = "AC" },
                    new VehicleBrandEntity { Name = "Abarth" },
                    new VehicleBrandEntity { Name = "Acura" },
                    new VehicleBrandEntity { Name = "Aixam" },
                    new VehicleBrandEntity { Name = "Alfa Romeo" },
                    new VehicleBrandEntity { Name = "Alpina" },
                    new VehicleBrandEntity { Name = "Aro" },
                    new VehicleBrandEntity { Name = "Asia" },
                    new VehicleBrandEntity { Name = "Aston martin" },
                    new VehicleBrandEntity { Name = "Audi" },
                    new VehicleBrandEntity { Name = "Austin" },
                    new VehicleBrandEntity { Name = "BMW" },
                    new VehicleBrandEntity { Name = "Bentley" },
                    new VehicleBrandEntity { Name = "Berliner" },
                    new VehicleBrandEntity { Name = "Bertone" },
                    new VehicleBrandEntity { Name = "Borgward" },
                    new VehicleBrandEntity { Name = "Brilliance" },
                    new VehicleBrandEntity { Name = "Bugatti" },
                    new VehicleBrandEntity { Name = "Buick" },
                    new VehicleBrandEntity { Name = "Cadillac" },
                    new VehicleBrandEntity { Name = "Carbodies" },
                    new VehicleBrandEntity { Name = "Chery" },
                    new VehicleBrandEntity { Name = "Chevrolet" },
                    new VehicleBrandEntity { Name = "Chrysler" },
                    new VehicleBrandEntity { Name = "Citroen" },
                    new VehicleBrandEntity { Name = "Corvette" },
                    new VehicleBrandEntity { Name = "Cupra" },
                    new VehicleBrandEntity { Name = "DONGFENG" },
                    new VehicleBrandEntity { Name = "DS" },
                    new VehicleBrandEntity { Name = "Dacia" },
                    new VehicleBrandEntity { Name = "Daewoo" },
                    new VehicleBrandEntity { Name = "Daihatsu" },
                    new VehicleBrandEntity { Name = "Daimler" },
                    new VehicleBrandEntity { Name = "Datsun" },
                    new VehicleBrandEntity { Name = "Dkw" },
                    new VehicleBrandEntity { Name = "Dodge" },
                    new VehicleBrandEntity { Name = "Dr" },
                    new VehicleBrandEntity { Name = "Eagle" },
                    new VehicleBrandEntity { Name = "FSO" },
                    new VehicleBrandEntity { Name = "Ferrari" },
                    new VehicleBrandEntity { Name = "Fiat" },
                    new VehicleBrandEntity { Name = "Ford" },
                    new VehicleBrandEntity { Name = "GOUPIL" },
                    new VehicleBrandEntity { Name = "Gaz" },
                    new VehicleBrandEntity { Name = "Geely" },
                    new VehicleBrandEntity { Name = "Genesis" },
                    new VehicleBrandEntity { Name = "Geo" },
                    new VehicleBrandEntity { Name = "Gmc" },
                    new VehicleBrandEntity { Name = "Gonow" },
                    new VehicleBrandEntity { Name = "Great Wall" },
                    new VehicleBrandEntity { Name = "Haval" },
                    new VehicleBrandEntity { Name = "Heinkel" },
                    new VehicleBrandEntity { Name = "Hillman" },
                    new VehicleBrandEntity { Name = "Honda" },
                    new VehicleBrandEntity { Name = "Hummer" },
                    new VehicleBrandEntity { Name = "Hyundai" },
                    new VehicleBrandEntity { Name = "Ifa" },
                    new VehicleBrandEntity { Name = "Infiniti" },
                    new VehicleBrandEntity { Name = "Innocenti" },
                    new VehicleBrandEntity { Name = "Isuzu" },
                    new VehicleBrandEntity { Name = "Iveco" },
                    new VehicleBrandEntity { Name = "JAC" },
                    new VehicleBrandEntity { Name = "JAS" },
                    new VehicleBrandEntity { Name = "Jaguar" },
                    new VehicleBrandEntity { Name = "Jeep" },
                    new VehicleBrandEntity { Name = "Jpx" },
                    new VehicleBrandEntity { Name = "Kia" },
                    new VehicleBrandEntity { Name = "Lada" },
                    new VehicleBrandEntity { Name = "Laforza" },
                    new VehicleBrandEntity { Name = "Lamborghini" },
                    new VehicleBrandEntity { Name = "Lancia" },
                    new VehicleBrandEntity { Name = "Land Rover" },
                    new VehicleBrandEntity { Name = "Landwind" },
                    new VehicleBrandEntity { Name = "Lexus" },
                    new VehicleBrandEntity { Name = "Lifan" },
                    new VehicleBrandEntity { Name = "Lincoln" },
                    new VehicleBrandEntity { Name = "Lotus" },
                    new VehicleBrandEntity { Name = "MG" },
                    new VehicleBrandEntity { Name = "Mahindra" },
                    new VehicleBrandEntity { Name = "Maserati" },
                    new VehicleBrandEntity { Name = "Matra" },
                    new VehicleBrandEntity { Name = "Maybach" },
                    new VehicleBrandEntity { Name = "Mazda" },
                    new VehicleBrandEntity { Name = "McLaren" },
                    new VehicleBrandEntity { Name = "Mercedes-Benz" },
                    new VehicleBrandEntity { Name = "Mercury" },
                    new VehicleBrandEntity { Name = "Mg" },
                    new VehicleBrandEntity { Name = "Microcar" },
                    new VehicleBrandEntity { Name = "Mini" },
                    new VehicleBrandEntity { Name = "Mitsubishi" },
                    new VehicleBrandEntity { Name = "Morgan" },
                    new VehicleBrandEntity { Name = "Moskvich" },
                    new VehicleBrandEntity { Name = "Nissan" },
                    new VehicleBrandEntity { Name = "Oldsmobile" },
                    new VehicleBrandEntity { Name = "Opel" },
                    new VehicleBrandEntity { Name = "Perodua" },
                    new VehicleBrandEntity { Name = "Peugeot" },
                    new VehicleBrandEntity { Name = "Pgo" },
                    new VehicleBrandEntity { Name = "Plymouth" },
                    new VehicleBrandEntity { Name = "Polestar" },
                    new VehicleBrandEntity { Name = "Polonez" },
                    new VehicleBrandEntity { Name = "Pontiac" },
                    new VehicleBrandEntity { Name = "Porsche" },
                    new VehicleBrandEntity { Name = "Proton" },
                    new VehicleBrandEntity { Name = "Qoros" },
                    new VehicleBrandEntity { Name = "Renault" },
                    new VehicleBrandEntity { Name = "Rieju" },
                    new VehicleBrandEntity { Name = "Rolls-Royce" },
                    new VehicleBrandEntity { Name = "Rover" },
                    new VehicleBrandEntity { Name = "SECMA" },
                    new VehicleBrandEntity { Name = "SH auto" },
                    new VehicleBrandEntity { Name = "Saab" },
                    new VehicleBrandEntity { Name = "Samand" },
                    new VehicleBrandEntity { Name = "Santana" },
                    new VehicleBrandEntity { Name = "Saturn" },
                    new VehicleBrandEntity { Name = "Scion" },
                    new VehicleBrandEntity { Name = "Seat" },
                    new VehicleBrandEntity { Name = "Shatenet" },
                    new VehicleBrandEntity { Name = "Shuanghuan" },
                    new VehicleBrandEntity { Name = "Simca" },
                    new VehicleBrandEntity { Name = "Skoda" },
                    new VehicleBrandEntity { Name = "Smart" },
                    new VehicleBrandEntity { Name = "Ssang yong" },
                    new VehicleBrandEntity { Name = "SsangYong" },
                    new VehicleBrandEntity { Name = "Subaru" },
                    new VehicleBrandEntity { Name = "Suzuki" },
                    new VehicleBrandEntity { Name = "Talbot" },
                    new VehicleBrandEntity { Name = "Tata" },
                    new VehicleBrandEntity { Name = "Tavria" },
                    new VehicleBrandEntity { Name = "Tazzari" },
                    new VehicleBrandEntity { Name = "Tempo" },
                    new VehicleBrandEntity { Name = "Terberg" },
                    new VehicleBrandEntity { Name = "Tesla" },
                    new VehicleBrandEntity { Name = "Tofas" },
                    new VehicleBrandEntity { Name = "Toyota" },
                    new VehicleBrandEntity { Name = "Trabant" },
                    new VehicleBrandEntity { Name = "Triumph" },
                    new VehicleBrandEntity { Name = "Uaz" },
                    new VehicleBrandEntity { Name = "VROMOS" },
                    new VehicleBrandEntity { Name = "VW" },
                    new VehicleBrandEntity { Name = "Volga" },
                    new VehicleBrandEntity { Name = "Volvo" },
                    new VehicleBrandEntity { Name = "Warszawa" },
                    new VehicleBrandEntity { Name = "Wartburg" },
                    new VehicleBrandEntity { Name = "Wiesmann" },
                    new VehicleBrandEntity { Name = "Xinkai" },
                    new VehicleBrandEntity { Name = "Xinshun" },
                    new VehicleBrandEntity { Name = "Yogomo" },
                    new VehicleBrandEntity { Name = "Zastava" },
                    new VehicleBrandEntity { Name = "Zaz" },
                    new VehicleBrandEntity { Name = "Other" },
                    new VehicleBrandEntity { Name = "Победа" },
                    new VehicleBrandEntity { Name = "София" },
                    new VehicleBrandEntity { Name = "Чайка" }
                );

            modelBuilder
                .Entity<VehicleModelEntity>()
                .ToTable("Models");

            modelBuilder
                .Entity<OwnerEntity>()
                .ToTable("Owners");
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var insertedEntries = this.ChangeTracker.Entries()
                                   .Where(x => x.State == EntityState.Added)
                                   .Select(x => x.Entity);

            foreach (var insertedEntry in insertedEntries)
            {
                var auditableEntity = insertedEntry as BaseEntity;
                //If the inserted object is an Auditable. 
                if (auditableEntity != null)
                {
                    auditableEntity.DateCreated = DateTimeOffset.UtcNow;
                }
            }

            var modifiedEntries = this.ChangeTracker.Entries()
                       .Where(x => x.State == EntityState.Modified)
                       .Select(x => x.Entity);

            foreach (var modifiedEntry in modifiedEntries)
            {
                //If the inserted object is an Auditable. 
                var auditableEntity = modifiedEntry as BaseEntity;
                if (auditableEntity != null)
                {
                    auditableEntity.DateUpdated = DateTimeOffset.UtcNow;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
