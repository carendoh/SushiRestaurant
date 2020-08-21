using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Restaurant.DAL.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IEnumerable<UsersOrder> UsersOrders { get; set; }
    }
}
