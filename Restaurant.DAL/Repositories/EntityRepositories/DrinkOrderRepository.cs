using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces.IEntityRepositories;

namespace Restaurant.DAL.Repositories.EntityRepositories
{
    public class DrinkOrderRepository : GenericRepository<DrinkOrder, int>, IDrinkOrderRepository
    {
        public DrinkOrderRepository(RestaurantContext db) : base(db) { }
    }
}
