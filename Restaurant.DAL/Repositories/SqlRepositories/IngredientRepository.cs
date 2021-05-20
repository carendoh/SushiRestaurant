using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces.IRepositories;

namespace Restaurant.DAL.Repositories.SqlRepositories
{
    public class IngredientRepository : GenericRepository<Ingredient, int>, IIngredientRepository
    {
        public IngredientRepository(RestaurantContext db) : base(db)
        {
        }
    }
}
