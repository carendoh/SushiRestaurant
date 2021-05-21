using Restaurant.DAL.Sql.Entities;

namespace Restaurant.DAL.Interfaces.IRepositories
{
    public interface IOrderRepository : IGenericRepository<Order, int>
    {
    }
}
