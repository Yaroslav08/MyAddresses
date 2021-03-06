using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyAddresses.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<IList<TEntity>> CreateRangeAsync(IList<TEntity> entities);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<IList<TEntity>> UpdateRangeAsync(IList<TEntity> entities);
        Task<TEntity> RemoveAsync(TEntity entity);
        Task<IList<TEntity>> RemoveRangeAsync(IList<TEntity> entities);
        Task<TEntity> GetByWhereAsync(Expression<Func<TEntity, bool>> match);
        Task<TEntity> GetByWhereAsTrackingAsync(Expression<Func<TEntity, bool>> match);
        Task<List<TEntity>> GetListByWhereAsTrackingAsync(Expression<Func<TEntity, bool>> match);
        Task<List<TEntity>> GetListByWhereAsync(Expression<Func<TEntity, bool>> match);
        Task<List<TEntity>> GetAllAsync(int skip);
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<TEntity, bool>> match);
        Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> match);
    }
}