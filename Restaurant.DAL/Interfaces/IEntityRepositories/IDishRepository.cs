using Restaurant.DAL.Entities;

namespace Restaurant.DAL.Interfaces.IEntityRepositories
{
    public interface IDishRepository : IGenericRepository<Dish, int>
    {
    }
}
