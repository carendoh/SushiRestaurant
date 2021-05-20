using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces.IRepositories;
using Restaurant.DAL.Sql.EF;

namespace Restaurant.DAL.Sql.Repositories
{
    public class CategoryRepository : GenericRepository<Category, int>, ICategoryRepository
    {
        public CategoryRepository(RestaurantContext db) : base(db)
        {
        }
    }
}
