namespace Restaurant.DAL.Interfaces
{
    public interface IRestaurantDbSettings
    {
        string CategoryCollectionName { get; set; }
        
        string DishCollectionName { get; set; }

        string IngredientCollectionName { get; set; }

        string DrinkCollectionName { get; set; }
        
        string ConnectionString { get; set; }

        string DatabaseName { get; set; }
    }
}