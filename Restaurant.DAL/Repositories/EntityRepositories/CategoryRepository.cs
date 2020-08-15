using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces.IEntityRepositories;

namespace Restaurant.DAL.Repositories.EntityRepositories
{
    public class CategoryRepository : GenericRepository<Category, int>, ICategoryRepository 
    {
        public CategoryRepository(RestaurantContext db)
        :base(db) { }
    }
}
