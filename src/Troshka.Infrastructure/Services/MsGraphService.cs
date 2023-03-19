using Microsoft.Graph;
using Troshka.Infrastructure.Interfaces;

namespace Troshka.Infrastructure.Services;

public class MsGraphService : IMsGraphService
{
    public MsGraphService()
    {
    }

    public async Task<IEnumerable<User>> GetUsersAsync(string accessToken)
    {
        return null;
    }
}
