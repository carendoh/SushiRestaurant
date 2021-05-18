using System;
using System.Collections.Generic;

namespace Restaurant.DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }
        
        public DateTime OrderDate { get; set; }
        
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        
        public virtual IEnumerable<DishOrder> DishOrders { get; set; }
        
        public virtual IEnumerable<DrinkOrder> DrinkOrders { get; set; }
    }
}
