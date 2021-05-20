using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces.IRepositories;

namespace Restaurant.DAL.Repositories.SqlRepositories
{
    public class DrinkRepository : GenericRepository<Drink, int>, IDrinkRepository
    {
        public DrinkRepository(RestaurantContext db) : base(db)
        {
        }
    }
}
