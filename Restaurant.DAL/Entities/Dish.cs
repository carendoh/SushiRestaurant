using System.Collections.Generic;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL.Entities
{
    public class Dish : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public double Mass { get; set; }
        public bool IsVegan { get; set; }
        public bool IsPublished { get; set; }
        
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        public IEnumerable<DishIngredient> DishIngredients { get; set; }
        public IEnumerable<DishOrder> DishOrders { get; set; }
    }
}
