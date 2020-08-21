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
                    new Dish { Id = 1, Name = "Ravioli", Mass = 340, Price = 7.5, Description = "Just Ravioli, nothing more" },
                    new Dish { Id = 2, Name = "Pizza", Mass = 500, Price = 10, Description = "Best Pizza in the World!" },
                    new Dish { Id = 3, Name = "Rice", Mass = 200, Price = 2.25, Description = "Rice with milk and sugar" },
                });
        }
    }
}
