using Restaurant.DAL.Interfaces;
using Restaurant.DAL.MongoDb.Interfaces;
using Restaurant.DAL.MongoDb.Entities;

namespace Restaurant.DAL.MongoDb.Repositories
{
    public class CategoryRepository : GenericRepository<Category, int>, ICategoryRepository
    {
        public CategoryRepository(IRestaurantDbSettings settings)
            : base(settings, settings.CategoryCollectionName)
        {
        }
    }
}
