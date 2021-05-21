using Restaurant.DAL.Interfaces;
using Restaurant.DAL.MongoDb.Interfaces;
using Restaurant.DAL.MongoDb.Entities;

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
