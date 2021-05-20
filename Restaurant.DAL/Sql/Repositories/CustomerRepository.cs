using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces.IRepositories;
using Restaurant.DAL.Sql.EF;

namespace Restaurant.DAL.Sql.Repositories
{
    public class CustomerRepository : GenericRepository<Customer, int>, ICustomerRepository
    {
        public CustomerRepository(RestaurantContext db) : base(db)
        {
        }
    }
}
