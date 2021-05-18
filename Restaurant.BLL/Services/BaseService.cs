using AutoMapper;
using Restaurant.DAL;

// ReSharper disable once CheckNamespace
namespace Restaurant.BLL.Services
{
    public abstract class BaseService
    {
        protected RestaurantContext Context { get; }
        protected IMapper Mapper { get; }
        
        protected BaseService(RestaurantContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }
    }
}