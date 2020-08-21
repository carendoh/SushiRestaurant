using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL.Entities
{
    public class DrinkOrder : IEntity<int>
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public int UsersOrderId { get; set; }
        public UsersOrder UsersOrder { get; set; }

        public int DrinkId { get; set; }
        public Drink Drink { get; set; }
    }
}
