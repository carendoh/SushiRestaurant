using Microsoft.AspNetCore.Identity;
using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces.IEntityRepositories;

namespace Restaurant.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        IDishRepository DishRepository { get; }
        IDrinkRepository DrinkRepository { get; }
        IIngredientRepository IngredientRepository { get; }

        UserManager<User> UserManager { get; }
        SignInManager<User> SignInManager { get; }
        RoleManager<IdentityRole> RoleManager { get; }
    }
}
