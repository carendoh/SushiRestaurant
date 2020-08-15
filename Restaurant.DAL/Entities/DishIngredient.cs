using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL.Entities
{
    public class DishIngredient : IEntity<int>
    {
        public int Id { get; set; }

        public int DishId { get; set; }
        public Dish Dish { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
