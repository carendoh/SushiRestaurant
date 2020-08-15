using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces.IEntityRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.DAL.Repositories.EntityRepositories
{
    public class IngredientRepository : GenericRepository<Ingredient, int>, IIngredientRepository
    {
        public IngredientRepository(RestaurantContext db)
            : base(db) { }
    }
}
