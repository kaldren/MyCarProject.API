using Microsoft.AspNetCore.Http;

namespace Troshka.Infrastructure.Interfaces
{
    public interface IAzureImageStoreService
    {
        Task StoreImageAsync(string imageName, string containerName, IFormFile file);

        bool IsImage(byte[] file);
    }
}
