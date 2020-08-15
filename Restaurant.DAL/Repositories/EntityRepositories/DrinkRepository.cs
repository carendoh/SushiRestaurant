using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces.IEntityRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.DAL.Repositories.EntityRepositories
{
    public class DrinkRepository : GenericRepository<Drink, int>, IDrinkRepository
    {
        public DrinkRepository(RestaurantContext db)
            : base(db) { }
    }
}
