using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL.MongoDb
{
    public class RestaurantDbSettings : IRestaurantDbSettings
    {
        public string CategoryCollectionName { get; set; }

        public string DishCollectionName { get; set; }

        public string IngredientCollectionName { get; set; }

        public string DrinkCollectionName { get; set; }

        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }
}
