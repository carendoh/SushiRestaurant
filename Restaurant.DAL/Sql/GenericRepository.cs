using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Restaurant.DAL.Interfaces;
using Restaurant.DAL.Sql.EF;

namespace Restaurant.DAL.Sql
{
    public class GenericRepository<TEntity, T> : IGenericRepository<TEntity, T> where TEntity : class, IEntity<T>
    {
        protected RestaurantContext Db { get; }

        protected DbSet<TEntity> Entities => Db.Set<TEntity>();

        protected GenericRepository(RestaurantContext db)
        {
            Db = db;
        }

        public async Task AddAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            
            await Entities.AddAsync(entity);
            await Db.SaveChangesAsync();
        }

        public async Task<bool> AnyAsync(T id)
        {
            return await Entities.AnyAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            
            Entities.Remove(entity);
            await Db.SaveChangesAsync();
        }

        public async Task<TEntity> GetByIdAsync(T id)
        {
           return await Entities.AsNoTracking()
               .FirstOrDefaultAsync(e => e.Id.Equals(id));
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Entities.AsNoTracking()
                .ToListAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            
            Entities.Update(entity);
            await Db.SaveChangesAsync();
        }
    }
}
