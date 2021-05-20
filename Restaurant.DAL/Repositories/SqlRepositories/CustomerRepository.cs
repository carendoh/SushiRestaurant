using Restaurant.DAL.EF;
using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces.IRepositories;

namespace Restaurant.DAL.Repositories.SqlRepositories
{
    public class CustomerRepository : GenericRepository<Customer, int>, ICustomerRepository
    {
        public CustomerRepository(RestaurantContext db) : base(db)
        {
        }
    }
}
