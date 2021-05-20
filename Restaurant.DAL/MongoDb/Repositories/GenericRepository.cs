using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL.MongoDb.Repositories
{
    public class GenericRepository<TEntity, T> : IGenericRepository<TEntity, T> where TEntity : class, IEntity<T>
    {
        public GenericRepository(IRestaurantDbSettings settings,
            string collectionName)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            Collection = database.GetCollection<TEntity>(collectionName);
        }

        protected IMongoCollection<TEntity> Collection { get; }

        public async Task AddAsync(TEntity entity)
        {
            await Collection.InsertOneAsync(entity);
        }

        public async Task<bool> AnyAsync(T id)
        {
            return await Collection.FindAsync(e => e.Id.Equals(id)) != null;
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Collection.DeleteOneAsync(e => e.Id.Equals(entity.Id));
        }

        public async Task<TEntity> GetByIdAsync(T id)
        {
            return await Collection.Find(e => e.Id.Equals(id)).SingleAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Collection.Find(e => true).ToListAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Collection.ReplaceOneAsync(e => e.Id.Equals(entity.Id), entity);
        }
    }
}