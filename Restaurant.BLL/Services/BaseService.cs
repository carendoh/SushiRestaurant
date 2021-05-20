using System;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Restaurant.BLL.Interfaces.IServices;
using Restaurant.DAL;
using Restaurant.DAL.Sql.EF;

namespace Restaurant.BLL.Services
{
    public abstract class BaseService<T> : IBaseService<T>
        where T : class
    {
        protected RestaurantContext Context { get; }
        protected IMapper Mapper { get; }

        protected DbSet<T> Entities => Context.Set<T>();
        
        protected BaseService(RestaurantContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }
        
        public T Delete(T entity)
        {
            if (entity == null)
            {
                throw new NotImplementedException();
            }

            Entities.Remove(entity);
            return entity;
        }

        public T Insert(T entity)
        {
            if (entity == null)
            {
                throw new NotImplementedException();
            }

            Entities.Add(entity);
            return entity;
        }

        public T Update(T entity)
        {
            if (entity == null)
            {
                throw new NotImplementedException();
            }

            Entities.Update(entity);
            return entity;
        }
    }
}