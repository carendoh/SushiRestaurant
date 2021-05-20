using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restaurant.DAL.Entities;

namespace Restaurant.DAL.Sql.EF
{
    public class RestaurantContext : IdentityDbContext<User>
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Dish> Dishes { get; set; }

        public DbSet<DishOrder> DishOrders { get; set; }

        public DbSet<Drink> Drinks { get; set; }

        public DbSet<Drink> DrinkOrders { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
