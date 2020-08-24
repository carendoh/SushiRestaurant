using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces.IEntityRepositories;

namespace Restaurant.DAL.Repositories.EntityRepositories
{
    public class DishOrderRepository : GenericRepository<DishOrder, int>, IDishOrderRepository
    {
        public DishOrderRepository(RestaurantContext db) : base(db) { }
    }
}
