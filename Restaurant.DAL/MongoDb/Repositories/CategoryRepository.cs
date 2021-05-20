using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces;
using Restaurant.DAL.Interfaces.IRepositories;

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
