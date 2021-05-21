using Restaurant.DAL.Interfaces.IRepositories;
using Restaurant.DAL.Sql.EF;
using Restaurant.DAL.Sql.Entities;

namespace Restaurant.DAL.Sql.Repositories
{
    public class OrderRepository : GenericRepository<Order, int>, IOrderRepository
    {
        public OrderRepository(RestaurantContext db) : base(db)
        {
        }
    }
}
