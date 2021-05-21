using Restaurant.DAL.Sql.Entities;

namespace Restaurant.DAL.Interfaces.IRepositories
{
    public interface IDishRepository : IGenericRepository<Dish, int>
    {
    }
}
