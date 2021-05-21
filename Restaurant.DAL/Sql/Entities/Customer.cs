using System.Collections.Generic;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL.Sql.Entities
{
    public class Customer : IEntity<int>
    {
        public int Id { get; set; }
        
        public string Surname { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Address { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public int? UserId { get; set; }
        
        public User User { get; set; }

        public IEnumerable<Order> Orders { get; set; }
    }
}
