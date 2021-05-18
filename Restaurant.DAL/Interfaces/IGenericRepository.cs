using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurant.DAL.Interfaces
{
    public interface IGenericRepository<TEntity, T> where TEntity : class, IEntity<T>
    {
        Task Add(TEntity entity);
        Task<bool> Any(T id);
        Task Delete(TEntity entity);
        Task<TEntity> Get(T id);
        Task<IEnumerable<TEntity>> GetAll();
        Task Update(TEntity entity);
    }
}
