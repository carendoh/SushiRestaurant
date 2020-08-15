using Microsoft.EntityFrameworkCore;
using Restaurant.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Restaurant.DAL.Configuration;

namespace Restaurant.DAL
{
    public partial class RestaurantContext : IdentityDbContext<User>
    {
        public RestaurantContext() { }

        public RestaurantContext(DbContextOptions<RestaurantContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<DishIngredient> DishIngredients { get; set; }
        public virtual DbSet<Drink> Drinks { get; set; }
        public virtual DbSet<DrinkIngredient> DrinkIngredients { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Configuration
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new DishConfiguration());
            #endregion

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Dish>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(c => c.Dishes)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Dishes_Categories");
            });

            modelBuilder.Entity<DishIngredient>(entity =>
            {
                entity.HasIndex(e => new { e.DishId, e.IngredientId })
                    .HasName("UIX_DishId_IngredientId")
                    .IsUnique();

                entity.HasOne(di => di.Dish)
                    .WithMany(d => d.DishIngredients)
                    .HasForeignKey(di => di.DishId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Dishes_DishIngredients");

                entity.HasOne(di => di.Ingredient)
                    .WithMany(i => i.DishIngredients)
                    .HasForeignKey(di => di.IngredientId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Ingredients_DishIngredients");
            });

            modelBuilder.Entity<Drink>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<DrinkIngredient>(entity =>
            {
                entity.HasIndex(e => new { e.DrinkId, e.IngredientId })
                .HasName("UIX_DrinkId_IngredientId")
                .IsUnique();

                entity.HasOne(di => di.Drink)
                .WithMany(d => d.DrinkIngredients)
                .HasForeignKey(di => di.DrinkId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Drinks_DrinkIngredients");

                entity.HasOne(di => di.Ingredient)
                .WithMany(i => i.DrinkIngredients)
                .HasForeignKey(di => di.IngredientId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Ingredients_DrinkIngredients");
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
