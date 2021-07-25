﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rookie.Ecom.DataAccessor.Data;

namespace Rookie.Ecom.DataAccessor
{
    public static class ServiceRegister
    {
        public static void AddDataAccessorLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EcommerceDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("eShopDb"),
                b => b.MigrationsAssembly(typeof(EcommerceDbContext).Assembly.FullName)
                ));
        }
    }
}