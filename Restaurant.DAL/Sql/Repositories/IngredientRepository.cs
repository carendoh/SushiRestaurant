using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces.IRepositories;
using Restaurant.DAL.Sql.EF;

namespace Restaurant.DAL.Sql.Repositories
{
    public class IngredientRepository : GenericRepository<Ingredient, int>, IIngredientRepository
    {
        public IngredientRepository(RestaurantContext db) : base(db)
        {
        }
    }
}
