using Restaurant.DAL.Interfaces.IRepositories;
using Restaurant.DAL.Sql.EF;
using Restaurant.DAL.Sql.Entities;

namespace Restaurant.DAL.Sql.Repositories
{
    public class CategoryRepository : GenericRepository<Category, int>, ICategoryRepository
    {
        public CategoryRepository(RestaurantContext db) : base(db)
        {
        }
    }
}
