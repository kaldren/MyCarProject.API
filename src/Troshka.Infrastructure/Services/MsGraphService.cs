using Microsoft.Extensions.Configuration;
using Microsoft.Graph;
using Microsoft.Identity.Client;
using System.Net.Http.Headers;
using Troshka.Infrastructure.Interfaces;

namespace Troshka.Infrastructure.Services;

public class MsGraphService : IMsGraphService
{
    private readonly IConfiguration _config;

    public MsGraphService(IConfiguration config)
    {
        _config = config;
    }

    public async Task<IEnumerable<User>> GetUsersAsync(string accessToken)
    {
        return null;
    }

    public async Task<User> GetUserAsync(string id)
    {
        var graphClient = new GraphServiceClient(new DelegateAuthenticationProvider(async (requestMessage) =>
        {
            var app = ConfidentialClientApplicationBuilder
                .Create(_config["AzureAd:ClientId"])
                .WithClientSecret(_config["AzureAd:ClientSecret"])
                .WithAuthority(new Uri($"{_config["AzureAd:Instance"]}/{_config["AzureAd:TenantId"]}"))
                .Build();

            var authResult = await app.AcquireTokenForClient(new string[] { "https://graph.microsoft.com/.default" })
                .ExecuteAsync();
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken);

        }));

        var user = await graphClient.Users[id]
            .Request()
            .Select(u => new
            {
                u.Id,
                u.Mail,
                u.DisplayName
            })
            .GetAsync();

        return user;
    }
}
