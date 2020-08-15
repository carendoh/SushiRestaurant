using Microsoft.AspNetCore.Identity;
using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces;
using Restaurant.DAL.Interfaces.IEntityRepositories;

namespace Restaurant.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IDishRepository dishRepository;
        private readonly IDrinkRepository drinkRepository;
        private readonly IIngredientRepository ingredientRepository;

        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UnitOfWork(
            ICategoryRepository categoryRepository,
            IDishRepository dishRepository,
            IDrinkRepository drinkRepository,
            IIngredientRepository ingredientRepository,

            UserManager<User> userManager,
            SignInManager<User> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.categoryRepository = categoryRepository;
            this.dishRepository = dishRepository;
            this.drinkRepository = drinkRepository;
            this.ingredientRepository = ingredientRepository;

            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        public ICategoryRepository CategoryRepository => categoryRepository;
        public IDishRepository DishRepository => dishRepository;
        public IDrinkRepository DrinkRepository => drinkRepository;
        public IIngredientRepository IngredientRepository => ingredientRepository;

        public UserManager<User> UserManager => userManager;
        public SignInManager<User> SignInManager => signInManager;
        public RoleManager<IdentityRole> RoleManager => roleManager;
    }
}
