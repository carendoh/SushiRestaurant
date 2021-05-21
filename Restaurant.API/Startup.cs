using System;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Restaurant.BLL.Interfaces.IServices;
using Restaurant.BLL.Services;
using Restaurant.DAL;
using Restaurant.API.Mapping;
using Restaurant.DAL.Interfaces;
using Restaurant.DAL.Interfaces.IRepositories;
using Restaurant.DAL.MongoDb;
using Restaurant.DAL.Sql.EF;
using Restaurant.DAL.Sql.Entities;
using Restaurant.DAL.Sql.Repositories;
using StackExchange.Redis.Extensions.Core.Configuration;
using StackExchange.Redis.Extensions.Newtonsoft;

namespace Restaurant.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<RestaurantContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.Configure<RestaurantDbSettings>(
                Configuration.GetSection(nameof(RestaurantDbSettings)));

            services.AddAutoMapper(typeof(DishMapperProfile).GetTypeInfo().Assembly);
            
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "Restaurant.API", Version = "v1"});
            });

            #region Repositories
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IDishRepository, DishRepository>();
            services.AddTransient<IDrinkRepository, DrinkRepository>();
            services.AddTransient<IIngredientRepository, IngredientRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            #endregion

            #region Services
            services.AddTransient<IDishService, DishService>();
            #endregion

            #region Identity

            services.AddIdentity<User, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<RestaurantContext>();

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 4;
                options.Password.RequiredUniqueChars = 1;

                // Email settings.
                options.User.RequireUniqueEmail = true;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
            });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            #endregion

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddSingleton<IRestaurantDbSettings>(provider => 
                provider.GetRequiredService<IOptions<RestaurantDbSettings>>().Value);

            services.AddStackExchangeRedisExtensions<NewtonsoftSerializer>(_ =>
                Configuration.GetSection("Redis").Get<RedisConfiguration>());
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Restaurant.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
