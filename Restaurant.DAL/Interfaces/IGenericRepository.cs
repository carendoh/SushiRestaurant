using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurant.DAL.Interfaces
{
    public interface IGenericRepository<TEntity, T> where TEntity : class, IEntity<T>
    {
        Task AddAsync(TEntity entity);

        Task<bool> AnyAsync(T id);

        Task DeleteAsync(TEntity entity);

        Task<TEntity> GetByIdAsync(T id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task UpdateAsync(TEntity entity);
    }
}
