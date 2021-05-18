namespace Restaurant.BLL.DTOs
{
    public class DishDto
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public double Price { get; set; }
        
        public string Description { get; set; }
        
        public double Mass { get; set; }
        
        public bool IsVegan { get; set; }
        
        public bool IsPublished { get; set; }

        public virtual CategoryDto Category { get; set; }
    }
}