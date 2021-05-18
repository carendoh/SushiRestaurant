using System.Collections.Generic;

namespace Restaurant.DAL.Entities
{
    public class Dish
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public double Price { get; set; }
        
        public string Description { get; set; }
        
        public double Mass { get; set; }
        
        public bool IsVegan { get; set; }
        
        public bool IsPublished { get; set; }
        
        public int? CategoryId { get; set; }
        

        public virtual Category Category { get; set; }
        
        public virtual IEnumerable<Ingredient> Ingredients { get; set; }
        
        public virtual IEnumerable<DishOrder> DishOrders { get; set; }
    }
}
