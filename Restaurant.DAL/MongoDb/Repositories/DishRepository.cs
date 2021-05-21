using Restaurant.DAL.Interfaces;
using Restaurant.DAL.MongoDb.Interfaces;
using Restaurant.DAL.MongoDb.Entities;

namespace Restaurant.DAL.MongoDb.Repositories
{
    public class DishRepository : GenericRepository<Dish, int>, IDishRepository
    {
        public DishRepository(IRestaurantDbSettings settings)
            : base(settings, settings.DishCollectionName)
        {
        }
    }
}
