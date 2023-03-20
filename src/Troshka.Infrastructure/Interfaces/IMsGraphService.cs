using Microsoft.Graph;

namespace Troshka.Infrastructure.Interfaces;

public interface IMsGraphService
{
    Task<IEnumerable<User>> GetUsersAsync(string accessToken);
    Task<User> GetUserAsync(string id);
}
