using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL.Entities
{
    public class DishOrder : IEntity<int>
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public int UsersOrderId { get; set; }
        public UsersOrder UsersOrder { get; set; }

        public int DishId { get; set; }
        public Dish Dish { get; set; }
    }
}
