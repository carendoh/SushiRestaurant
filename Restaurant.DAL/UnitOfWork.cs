using Restaurant.DAL.Interfaces;
using Restaurant.DAL.Interfaces.IRepositories;

namespace Restaurant.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ICategoryRepository categoryRepository,
            ICustomerRepository customerRepository,
            IDishRepository dishRepository,
            IDrinkRepository drinkRepository,
            IIngredientRepository ingredientRepository,
            IOrderRepository orderRepository)
        {
            CategoryRepository = categoryRepository;
            CustomerRepository = customerRepository;
            DishRepository = dishRepository;
            DrinkRepository = drinkRepository;
            IngredientRepository = ingredientRepository;
            OrderRepository = orderRepository;
        }

        public ICategoryRepository CategoryRepository { get; }

        public ICustomerRepository CustomerRepository { get; }

        public IDishRepository DishRepository { get; }

        public IDrinkRepository DrinkRepository { get; }

        public IIngredientRepository IngredientRepository { get; }

        public IOrderRepository OrderRepository { get; }
    }
}
