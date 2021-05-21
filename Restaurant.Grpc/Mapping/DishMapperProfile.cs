using AutoMapper;
using Restaurant.DAL.Sql.Entities;
using Restaurant.Grpc.GrpcServices;

namespace Restaurant.Grpc.Mapping
{
    public class DishMapperProfile : Profile
    {
        public DishMapperProfile()
        {
            CreateMap<Dish, DishProto>().ReverseMap();
        }
    }
}