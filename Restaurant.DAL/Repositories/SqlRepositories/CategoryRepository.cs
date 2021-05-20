using Restaurant.DAL.EF;
using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces.IRepositories;

namespace Restaurant.DAL.Repositories.SqlRepositories
{
    public class CategoryRepository : GenericRepository<Category, int>, ICategoryRepository
    {
        public CategoryRepository(RestaurantContext db) : base(db)
        {
        }
    }
}
