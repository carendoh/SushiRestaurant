using Restaurant.DAL.Interfaces.IRepositories;
using Restaurant.DAL.Sql.EF;
using Restaurant.DAL.Sql.Entities;

namespace Restaurant.DAL.Sql.Repositories
{
    public class DishRepository : GenericRepository<Dish, int>, IDishRepository
    {
        public DishRepository(RestaurantContext db) : base(db)
        {
        }
    }
}
