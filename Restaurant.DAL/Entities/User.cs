using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL.Entities
{
    public class User : IdentityUser, IEntity<string>
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public int CustomerId { get; set; }
        
        public IEnumerable<Customer> Customers { get; set; }
    }
}
