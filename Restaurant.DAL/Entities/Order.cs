using System;
using System.Collections.Generic;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL.Entities
{
    public class Order : IEntity<int>
    {
        public int Id { get; set; }
        
        public DateTime OrderDate { get; set; }
        
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        
        public virtual IEnumerable<DishOrder> DishOrders { get; set; }
        
        public virtual IEnumerable<DrinkOrder> DrinkOrders { get; set; }
    }
}
