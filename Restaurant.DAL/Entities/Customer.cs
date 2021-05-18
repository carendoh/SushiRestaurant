using System.Collections.Generic;

namespace Restaurant.DAL.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        
        public string Surname { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Address { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public int? UserId { get; set; }

        public virtual IEnumerable<User> Users { get; set; }
        
        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
