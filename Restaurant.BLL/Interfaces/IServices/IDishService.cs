using System.Collections.Generic;
using System.Threading.Tasks;
using Restaurant.BLL.DTOs;
using Restaurant.DAL.Sql.Entities;

namespace Restaurant.BLL.Interfaces.IServices
{
    public interface IDishService : IBaseService<Dish>
    {
        Task AddAsync(DishDto dish);

        Task DeleteAsync(int id);
        
        Task<DishDto> GetByIdAsync(int id);

        Task<IEnumerable<DishDto>> GetAllAsync();

        Task UpdateAsync(DishDto dish);
    }
}
