using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Restaurant.BLL.DTOs;
using Restaurant.BLL.Interfaces.IServices;
using Restaurant.DAL;
using Restaurant.DAL.Entities;
using System.Linq;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using Restaurant.DAL.Sql.EF;

namespace Restaurant.BLL.Services
{
    public class DishService : BaseService<Dish>, IDishService
    {
        public DishService(RestaurantContext context, IMapper mapper)
            :base(context, mapper)
        {
        }
        
        public async Task AddAsync(DishDto dishDto)
        {
            var dish = Mapper.Map<Dish>(dishDto);
            Insert(dish);
            await Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var dish = await Entities.AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id.Equals(id));
            Delete(dish);
            await Context.SaveChangesAsync();
        }

        public async Task<DishDto> GetByIdAsync(int id)
        {
            var dish = await Entities.AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id.Equals(id));

            return Mapper.Map<DishDto>(dish);
        }

        public async Task<IEnumerable<DishDto>> GetAllAsync()
        {
            var dishes = await Entities.AsNoTracking()
                .ToListAsync();

            return Mapper.Map<IEnumerable<DishDto>>(dishes);
        }

        public async Task UpdateAsync(DishDto dishDto)
        {
            var dish = Mapper.Map<Dish>(dishDto);
            Update(dish);
            await Context.SaveChangesAsync();
        }
    }
}
