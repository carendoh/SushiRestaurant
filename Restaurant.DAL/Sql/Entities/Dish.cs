using System.Collections.Generic;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL.Sql.Entities
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


        public virtual Category Category { get; set; }

        public virtual IEnumerable<Ingredient> Ingredients { get; set; }

        public virtual IEnumerable<DishOrder> DishOrders { get; set; }
    }
}
