using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces;
using Restaurant.DAL.Interfaces.IRepositories;

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
