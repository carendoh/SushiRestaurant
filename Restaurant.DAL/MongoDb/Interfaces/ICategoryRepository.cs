using Restaurant.DAL.Interfaces;
using Restaurant.DAL.MongoDb.Entities;

namespace Restaurant.DAL.MongoDb.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<Category, int>
    {
    }
}
