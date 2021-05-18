using AutoMapper;
using Restaurant.BLL.DTOs;
using Restaurant.DAL.Entities;

namespace Restaurant.API.Mapping
{
    public class DishMapperProfile : Profile
    {
        public DishMapperProfile()
        {
            CreateMap<Dish, DishDto>().ReverseMap();
        }
    }
}
