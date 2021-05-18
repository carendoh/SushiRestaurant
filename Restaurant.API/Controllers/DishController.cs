using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BLL.DTOs;
using Restaurant.BLL.Interfaces.IServices;
using StackExchange.Redis.Extensions.Core.Abstractions;

namespace Restaurant.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DishController : ControllerBase
    {
        private readonly IRedisDatabase _redisDatabase;
        private readonly IDishService _dishService;

        public DishController(
            IRedisDatabase redisDatabase,
            IDishService dishService)
        {
            _redisDatabase = redisDatabase;
            _dishService = dishService;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult> Add(DishDto dish)
        {
            await _dishService.AddAsync(dish);

            return Ok(dish);
        }

        [HttpDelete]
        [Route("[action]")]
        public async Task<ActionResult> DeleteById(int id)
        {
            await _dishService.DeleteAsync(id);

            return Ok();
        }

        [HttpGet]
        [Route("All")]
        public async Task<ActionResult<IEnumerable<DishDto>>> GetAll()
        {
            const string key = "AllDishes";

            var dishes = await _redisDatabase.GetAsync<IEnumerable<DishDto>>(key);

            if (dishes != null)
            {
                return Ok(dishes);
            }

            dishes = await _dishService.GetAllAsync();

            await _redisDatabase.AddAsync(key, dishes,DateTimeOffset.Now.AddMinutes(2));

            return Ok(dishes);
        }

        [HttpGet]
        [Route("{id:int}/Get")]
        public async Task<ActionResult<DishDto>> GetById(int id)
        {
            var dish = await _dishService.GetByIdAsync(id);

            return Ok(dish);
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult> Update(DishDto dish)
        {
            await _dishService.UpdateAsync(dish);

            return Ok();
        }
    }
}
