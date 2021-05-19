using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis.Extensions.Core.Abstractions;

namespace Restaurant.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class RedisController : ControllerBase
    {
        private readonly IRedisCacheClient _redisCacheClient;
        private IRedisDatabase RedisDatabase => _redisCacheClient.GetDbFromConfiguration();
        
        public RedisController(IRedisCacheClient redisCacheClient)
        {
            _redisCacheClient = redisCacheClient;
        }
        
        [HttpGet]
        public async Task<IActionResult> SearchKeys()
        {
            // RedisDatabase.SearchKeysAsync("*con*")
            var allKeys = (await RedisDatabase.SearchKeysAsync("*")).ToList();
            
            return Ok(allKeys);
        }
        
        [HttpGet]
        [Route("{key}")]
        public async Task<IActionResult> Remove(string key)
        {
            await RedisDatabase.RemoveAsync(key);
            return Ok();
        }
        
        [HttpGet]
        [Route("{pattern}")]
        public async Task<IActionResult> RemoveMultiple(string pattern)
        {
            var allKeys = (await RedisDatabase.SearchKeysAsync(pattern)).ToList();
            await RedisDatabase.RemoveAllAsync(allKeys);
            
            return Ok();
        }
        
        [HttpGet]
        public async Task<IActionResult> Clear()
        {
            await RedisDatabase.FlushDbAsync();
            return Ok();
        }
    }
}