using Restaurant.DAL.Sql.Entities;

namespace Restaurant.DAL.Interfaces.IRepositories
{
    public interface ICustomerRepository : IGenericRepository<Customer, int>
    {
    }
}
