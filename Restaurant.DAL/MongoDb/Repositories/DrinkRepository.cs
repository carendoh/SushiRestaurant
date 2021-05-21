using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces;
using Restaurant.DAL.Interfaces.IRepositories;

namespace Restaurant.DAL.MongoDb.Repositories
{
    public class DrinkRepository : GenericRepository<Drink, int>, IDrinkRepository
    {
        public DrinkRepository(IRestaurantDbSettings settings)
            : base(settings, settings.DrinkCollectionName)
        {
        }
    }
}
