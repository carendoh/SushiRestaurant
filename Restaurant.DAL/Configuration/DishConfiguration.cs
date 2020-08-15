using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.DAL.Entities;

namespace Restaurant.DAL.Configuration
{
    public class DishConfiguration : IEntityTypeConfiguration<Dish>
    {
        public void Configure(EntityTypeBuilder<Dish> builder)
        {
            builder.HasData(
                new Dish[]
                {
                    new Dish { Name = "Ravioli", Mass = 340, Price = 7.5, Description = "Just Ravioli, nothing more" },
                    new Dish { Name = "Pizza", Mass = 500, Price = 10, Description = "Best Pizza in the World!" },
                    new Dish { Name = "Rice", Mass = 200, Price = 2.25, Description = "Rice with milk and sugar" },
                });
        }
    }
}
