using CarShop.DAL.Interfaces;
using CarShop.DAL.Repositories;
using CarShop.Domain.Entity;
using CarShop.Service.Implementations;
using CarShop.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    public static class StartupInit
    {

        public static void InitializeRepositories(this IServiceCollection services)
        {

            services.AddScoped<IBaseRepository<Car>, CarRepository>();
            services.AddScoped<IBaseRepository<User>, UserRepository>();
            
        }

        public static void InitializeService(this IServiceCollection services)
        {

   
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<IAccountService, AccountService>();
        }
    }
}
