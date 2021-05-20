using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL.Repositories.SqlRepositories
{
    public class GenericRepository<TEntity, T> : IGenericRepository<TEntity, T> where TEntity : class, IEntity<T>
    {
        protected readonly RestaurantContext Db;
        
        public GenericRepository(RestaurantContext db)
        {
            Db = db;
        }
        
        public async Task Add(TEntity entity)
        {
            await Db.Set<TEntity>().AddAsync(entity);
            await Db.SaveChangesAsync();
        }

        public async Task<bool> Any(T id)
        {
            return await Db.Set<TEntity>().AnyAsync();
        }

        public async Task Delete(TEntity entity)
        {
            Db.Set<TEntity>().Remove(entity);
            await Db.SaveChangesAsync();
        }

        public async Task<TEntity> Get(T id)
        {
           return await Db.Set<TEntity>().FirstOrDefaultAsync(e => e.Id.Equals(id));
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await Db.Set<TEntity>().ToListAsync();
        }

        public async Task Update(TEntity entity)
        {
            Db.Set<TEntity>().Update(entity);
            await Db.SaveChangesAsync();
        }
    }
}