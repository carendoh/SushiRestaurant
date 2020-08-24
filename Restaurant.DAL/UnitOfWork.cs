using Microsoft.AspNetCore.Identity;
using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces;
using Restaurant.DAL.Interfaces.IEntityRepositories;

namespace Restaurant.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(
            ICategoryRepository CategoryRepository,
            IDishRepository DishRepository,
            IDrinkRepository DrinkRepository,
            IIngredientRepository IngredientRepository,
            IUsersOrderRepository UsersOrderRepository,
            IDishOrderRepository DishOrderRepository,
            IDrinkOrderRepository DrinkOrderRepository,

            UserManager<User> UserManager,
            SignInManager<User> SignInManager,
            RoleManager<IdentityRole> RoleManager)
        {
            this.CategoryRepository = CategoryRepository;
            this.DishRepository = DishRepository;
            this.DrinkRepository = DrinkRepository;
            this.IngredientRepository = IngredientRepository;
            this.UsersOrderRepository = UsersOrderRepository;
            this.DishOrderRepository = DishOrderRepository;
            this.DrinkOrderRepository = DrinkOrderRepository;

            this.UserManager = UserManager;
            this.SignInManager = SignInManager;
            this.RoleManager = RoleManager;
        }

        public ICategoryRepository CategoryRepository { get; }
        public IDishRepository DishRepository { get; }
        public IDrinkRepository DrinkRepository { get; }
        public IIngredientRepository IngredientRepository { get; }
        public IUsersOrderRepository UsersOrderRepository { get; }
        public IDishOrderRepository DishOrderRepository { get; }
        public IDrinkOrderRepository DrinkOrderRepository { get; }

        public UserManager<User> UserManager { get; }
        public SignInManager<User> SignInManager { get; }
        public RoleManager<IdentityRole> RoleManager { get; }
    }
}
