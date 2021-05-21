using System.Linq;
using Restaurant.DAL.Sql.Entities;

namespace Restaurant.DAL.Sql.EF
{
    public static class Initializer
    {
        public static void Initialize(RestaurantContext context)
        {
            if (context.Dishes.Any()) return;

            var dishes = new Dish[]
            {
                new() { Name = "Ravioli", Mass = 340, Price = 7.5, Description = "Just Ravioli, nothing more" },
                new() { Name = "Pizza", Mass = 500, Price = 10, Description = "Best Pizza in the World!" },
                new() { Name = "Rice", Mass = 200, Price = 2.25, Description = "Rice with milk and sugar" },
            };

            context.Dishes.AddRange(dishes);
            context.SaveChanges();
            
            var user = new User
            {
                UserName = "Carendoh",
                NormalizedUserName = "CARENDOH",
                FirstName = "Oleksandr",
                LastName = "Slobodian",
                Email = "test@gmail.com",
                NormalizedEmail = "TEST@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEEYOfbhhZP2uqLre7aNmNHV2NkGpy2nUQwx6Y8khu2hOAj2VZ1Q6hNyu34Yq0Dcl4g=="
            };

            context.Users.Add(user);

            context.SaveChanges();
        }
    }
}
