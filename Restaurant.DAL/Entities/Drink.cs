using System.Collections.Generic;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL.Entities
{
    public class Drink : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Volume { get; set; }
        public bool HasAlcohol { get; set; }

        public IEnumerable<DrinkIngredient> DrinkIngredients { get; set; }
    }
}
