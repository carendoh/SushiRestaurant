using Restaurant.DAL.Interfaces.IRepositories;

namespace Restaurant.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        
        ICustomerRepository CustomerRepository { get; }
        
        IDishRepository DishRepository { get; }
        
        IDrinkRepository DrinkRepository { get; }
        
        IIngredientRepository IngredientRepository { get; }
        
        IOrderRepository OrderRepository { get; }
    }
}