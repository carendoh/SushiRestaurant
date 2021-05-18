namespace Restaurant.DAL.Entities
{
    public class DrinkOrder
    {
        public int Id { get; set; }
       
        public int Number { get; set; }
        
        public int OrderId { get; set; }
        
        public int DrinkId { get; set; }

        public virtual Drink Drink { get; set; }
        
        public virtual Order Order { get; set; }
    }
}
