using Restaurant.DAL.Interfaces;
using Restaurant.DAL.MongoDb.Interfaces;
using Restaurant.DAL.MongoDb.Entities;

namespace Restaurant.DAL.MongoDb.Repositories
{
    public class IngredientRepository : GenericRepository<Ingredient, int>, IIngredientRepository
    {
        public IngredientRepository(IRestaurantDbSettings settings, string collectionName)
            : base(settings, settings.IngredientCollectionName)
        {
        }
    }
}
