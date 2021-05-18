using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Restaurant.DAL.Entities;

namespace Restaurant.DAL
{
    public class DbContext : IdentityDbContext<User>
    {
        
    }
}