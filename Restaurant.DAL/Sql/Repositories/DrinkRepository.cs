using Restaurant.DAL.Interfaces.IRepositories;
using Restaurant.DAL.Sql.EF;
using Restaurant.DAL.Sql.Entities;

namespace Restaurant.DAL.Sql.Repositories
{
    public class DrinkRepository : GenericRepository<Drink, int>, IDrinkRepository
    {
        public DrinkRepository(RestaurantContext db) : base(db)
        {
        }
    }
}
