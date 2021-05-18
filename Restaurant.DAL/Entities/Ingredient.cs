using System.Collections.Generic;

namespace Restaurant.DAL.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public virtual IEnumerable<Dish> Dishes { get; set; }
        
        public virtual IEnumerable<Drink> Drinks { get; set; }
    }
}
