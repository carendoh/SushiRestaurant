using System.Collections.Generic;

namespace Restaurant.DAL.Entities
{
    public class Drink
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public double Price { get; set; }
        
        public string Description { get; set; }
        
        public int Volume { get; set; }
        
        public bool HasAlcohol { get; set; }
        
        public bool IsPublished { get; set; }

        public virtual IEnumerable<Ingredient> Ingredients { get; set; }
        
        public virtual IEnumerable<DrinkOrder> DrinkOrders { get; set; }
    }
}
