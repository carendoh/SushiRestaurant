using System.Collections.Generic;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL.Entities
{
    public class Category : IEntity<int>
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public virtual IEnumerable<Dish> Dishes { get; set; }
    }
}
