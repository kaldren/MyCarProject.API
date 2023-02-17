using MyCarProject.Application.Interfaces;

namespace MyCarProject.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyCarProjectDbContext MyCarProjectDbContext;

        public UnitOfWork(MyCarProjectDbContext MyCarProjectDbContext)
        {
            this.MyCarProjectDbContext = MyCarProjectDbContext;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await MyCarProjectDbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            MyCarProjectDbContext.Dispose();
        }
    }
}
