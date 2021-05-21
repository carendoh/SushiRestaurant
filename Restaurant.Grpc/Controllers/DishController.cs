using System;
using System.Threading.Tasks;
using AutoMapper;
using Google.Protobuf.Collections;
using Grpc.Core;
using Restaurant.DAL.MongoDb.Interfaces;
using Restaurant.Grpc.GrpcServices;
using Restaurant.DAL.MongoDb.Entities;

namespace Restaurant.Grpc.Controllers
{
    public class DishController : DishService.DishServiceBase
    {
        private readonly IDishRepository _dishRepository;
        private readonly IMapper _mapper;
        
        public DishController(IDishRepository dishRepository,
            IMapper mapper)
        {
            _dishRepository = dishRepository;
            _mapper = mapper;
        }

        public override async Task<PostDishResponse> AddDish(PostDishRequest request, ServerCallContext context)
        {
            var dish =  _mapper.Map<Dish>(request.Dish);

            try
            {
                await _dishRepository.AddAsync(dish);

                return new PostDishResponse
                {
                    Success = true
                };
            }
            catch (Exception e)
            {
                return new PostDishResponse
                {
                    Success = false,
                    Error = e.Message
                };
            }
        }

        public override async Task<PostDishResponse> DeleteDish(GetDishRequest request, ServerCallContext context)
        {
            var dish = await _dishRepository.GetByIdAsync(request.Id);
            
            try
            {
                await _dishRepository.DeleteAsync(dish);

                return new PostDishResponse
                {
                    Success = true
                };
            }
            catch (Exception e)
            {
                return new PostDishResponse
                {
                    Success = false,
                    Error = e.Message
                };
            }
        }

        public override async Task<GetAllDishesResponse> GetAllDishes(GetAllDishesRequest request, ServerCallContext context)
        {
            var dishes = _mapper.Map<RepeatedField<DishProto>>(await _dishRepository.GetAllAsync());
            
            return new GetAllDishesResponse
            {
                Dishes = dishes
            };
        }

        public override async Task<GetDishResponse> GetDish(GetDishRequest request, ServerCallContext context)
        {
            var dish = _mapper.Map<DishProto>(await _dishRepository.GetByIdAsync(request.Id));

            return new GetDishResponse
            {
                Dish = dish
            };
        }

        public override async Task<PostDishResponse> UpdateDish(PostDishRequest request, ServerCallContext context)
        {
            var dish = _mapper.Map<Dish>(request.Dish);
            
            try
            {
                await _dishRepository.UpdateAsync(dish);

                return new PostDishResponse
                {
                    Success = true
                };
            }
            catch (Exception e)
            {
                return new PostDishResponse
                {
                    Success = false,
                    Error = e.Message
                };
            }
        }
    }
}
