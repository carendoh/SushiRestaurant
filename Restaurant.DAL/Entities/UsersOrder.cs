using Restaurant.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace Restaurant.DAL.Entities
{
    public class UsersOrder : IEntity<int>
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public IEnumerable<DishOrder> DishOrders { get; set; }
        public IEnumerable<DrinkOrder> DrinkOrders { get; set; }
    }
}
