using System.Collections.Generic;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL.Entities
{
    public class Ingredient : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<DishIngredient> DishIngredients { get; set; }
        public IEnumerable<DrinkIngredient> DrinkIngredients { get; set; }
    }
}
