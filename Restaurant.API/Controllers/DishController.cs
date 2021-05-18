using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurant.BLL.DTOs;
using Restaurant.BLL.Interfaces.IServices;

namespace Restaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishController : ControllerBase
    {
        private readonly ILogger<DishController> _logger;
        private readonly IDishService _dishService;

        public DishController(
            ILogger<DishController> logger,
            IDishService dishService)
        {
            _logger = logger;
            _dishService = dishService;
        }

        [HttpPost]
        public async Task<ActionResult> Add(DishDto dish)
        {
            await _dishService.AddAsync(dish);

            return Ok(dish);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteById(int id)
        {
            await _dishService.DeleteAsync(id);

            return Ok();
        }

        [HttpGet("All")]
        public async Task<ActionResult<IEnumerable<DishDto>>> GetAll()
        {
            _logger.LogInformation("Get all executed");
            var dishes = await _dishService.GetAllAsync();

            return Ok(dishes);
        }

        [HttpGet("{id:int}/Get")]
        public async Task<ActionResult<DishDto>> GetById(int id)
        {
            var dish = await _dishService.GetByIdAsync(id);

            return Ok(dish);
        }

        [HttpPut]
        public async Task<ActionResult> Update(DishDto dish)
        {
            await _dishService.UpdateAsync(dish);

            return Ok();
        }
    }
}
