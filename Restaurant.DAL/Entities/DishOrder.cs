namespace Restaurant.DAL.Entities
{
    public class DishOrder
    {
        public int Id { get; set; }
        
        public int Number { get; set; }
        
        public int OrderId { get; set; }
        
        public int DishId { get; set; }

        public virtual Dish Dish { get; set; }
        
        public virtual Order Order { get; set; }
    }
}
