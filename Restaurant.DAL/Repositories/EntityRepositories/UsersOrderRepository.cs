using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces.IEntityRepositories;

namespace Restaurant.DAL.Repositories.EntityRepositories
{
    public class UsersOrderRepository : GenericRepository<UsersOrder, int>, IUsersOrderRepository
    {
        public UsersOrderRepository(RestaurantContext db) : base(db) { }
    }
}
