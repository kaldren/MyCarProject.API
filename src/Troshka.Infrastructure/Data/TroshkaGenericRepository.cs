using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Troshka.Application.Interfaces;
using Troshka.Domain.Entities.VehicleAggregate;

namespace Troshka.Infrastructure.Data
{
    public class TroshkaGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly TroshkaDbContext _TroshkaDbContext;
        private DbSet<TEntity> _dbSet;

        public TroshkaGenericRepository(TroshkaDbContext TroshkaDbContext)
        {
            this._TroshkaDbContext = TroshkaDbContext;
            _dbSet = TroshkaDbContext.Set<TEntity>();
        }

        public void Delete(TEntity entity)
        {
            //If the type we are trying to delete is auditable, then we don't actually delete it but instead set it to be updated with a delete date. 
            if (typeof(BaseEntity).IsAssignableFrom(typeof(TEntity)))
            {
                (entity as BaseEntity).DateDeleted = DateTimeOffset.UtcNow;
                (entity as BaseEntity).IsDeleted = true;
                _dbSet.Attach(entity);
                _TroshkaDbContext.Entry(entity).State = EntityState.Modified;
            }
            else
            {
                _dbSet.Remove(entity);
            }
        }

        public async Task<TEntity?> GetSingleOrDefault(Expression<Func<TEntity, bool>> func)
            => await _dbSet.Where(func).FirstOrDefaultAsync();

        public async Task<ICollection<TEntity>> GetAsync(Expression<Func<TEntity, bool>> func)
            => await _dbSet.Where(func).ToListAsync();

        public async Task<TEntity?> GetAsync(string id)
            => await _dbSet.Where(p => p.Id == id && p.IsDeleted == false).SingleOrDefaultAsync();

        public void Insert(TEntity entity)
            => _dbSet.Add(entity);

        public void Update(TEntity entity)
            => _dbSet.Update(entity);

        public IQueryable<TEntity> GetQueryable(Expression<Func<TEntity, bool>> func)
            => _dbSet.Where(func).AsQueryable();

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> func)
            => _dbSet.Count(func);

        public IQueryable<TEntity> ExecuteRawSQL(string query, params object[] parameters)
        {
            return _dbSet.FromSqlRaw(query, parameters);
        }
    }
}
