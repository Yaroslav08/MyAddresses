using Microsoft.EntityFrameworkCore;
using MyAddresses.Constants;
using MyAddresses.Domain.Interfaces;
using MyAddresses.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyAddresses.Infrastructure.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly MyAddressContext db;
        protected readonly DbSet<TEntity> dbSet;
        public Repository()
        {
            db = new MyAddressContext();
            dbSet = db.Set<TEntity>();
        }

        public async Task<int> CountAsync()
        {
            return await db.Set<TEntity>().AsNoTracking().CountAsync();
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> match)
        {
            return await db.Set<TEntity>().AsNoTracking().CountAsync(match);
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await db.Set<TEntity>().AddAsync(entity);
            await SaveAsync();
            return entity;
        }

        public async Task<IList<TEntity>> CreateRangeAsync(IList<TEntity> entities)
        {
            await db.Set<TEntity>().AddRangeAsync(entities);
            await SaveAsync();
            return entities;
        }

        public async Task<List<TEntity>> GetAllAsync(int skip)
        {
            return await db.Set<TEntity>()
                .Skip(skip).Take(50)
                .AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetByWhereAsTrackingAsync(Expression<Func<TEntity, bool>> match)
        {
            return await db.Set<TEntity>().FirstOrDefaultAsync(match);
        }

        public async Task<TEntity> GetByWhereAsync(Expression<Func<TEntity, bool>> match)
        {
            return await db.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(match);
        }

        public async Task<List<TEntity>> GetListByWhereAsTrackingAsync(Expression<Func<TEntity, bool>> match)
        {
            return await db.Set<TEntity>().Where(match).ToListAsync();
        }

        public async Task<List<TEntity>> GetListByWhereAsync(Expression<Func<TEntity, bool>> match)
        {
            return await db.Set<TEntity>().AsNoTracking().Where(match).ToListAsync();
        }

        public async Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> match)
        {
            return await db.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(match) != null ? true : false;
        }

        public async Task<TEntity> RemoveAsync(TEntity entity)
        {
            db.Set<TEntity>().Remove(entity);
            await SaveAsync();
            return entity;
        }

        public async Task<IList<TEntity>> RemoveRangeAsync(IList<TEntity> entities)
        {
            db.Set<TEntity>().RemoveRange(entities);
            await SaveAsync();
            return entities;
        }

        public async Task<string> SaveAsync()
        {
            return await db.SaveChangesAsync() > 0 ? Constants.Constants.OK : Constants.Constants.Error;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            db.Set<TEntity>().Update(entity);
            await SaveAsync();
            return entity;
        }

        public async Task<IList<TEntity>> UpdateRangeAsync(IList<TEntity> entities)
        {
            db.Set<TEntity>().UpdateRange(entities);
            await SaveAsync();
            return entities;
        }
    }
}
