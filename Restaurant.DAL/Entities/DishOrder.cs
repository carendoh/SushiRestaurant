using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL.Entities
{
    public class DishOrder : IEntity<int>
    {
        public int Id { get; set; }
        
        public int Number { get; set; }
        
        public int OrderId { get; set; }
        
        public int DishId { get; set; }

        public virtual Dish Dish { get; set; }
        
        public virtual Order Order { get; set; }
    }
}
