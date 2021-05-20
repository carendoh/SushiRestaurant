using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces.IRepositories;

namespace Restaurant.DAL.Repositories.SqlRepositories
{
    public class DishRepository : GenericRepository<Dish, int>, IDishRepository
    {
        public DishRepository(RestaurantContext db) : base(db)
        {
        }
    }
}
