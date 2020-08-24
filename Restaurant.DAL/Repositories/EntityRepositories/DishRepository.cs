using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces.IEntityRepositories;

namespace Restaurant.DAL.Repositories.EntityRepositories
{
    public class DishRepository : GenericRepository<Dish, int>, IDishRepository
    {
        public DishRepository(RestaurantContext db) : base(db) { }
    }
}
