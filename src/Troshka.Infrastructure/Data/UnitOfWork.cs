using Troshka.Application.Interfaces;

namespace Troshka.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TroshkaDbContext TroshkaDbContext;

        public UnitOfWork(TroshkaDbContext TroshkaDbContext)
        {
            this.TroshkaDbContext = TroshkaDbContext;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await TroshkaDbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            TroshkaDbContext.Dispose();
        }
    }
}
