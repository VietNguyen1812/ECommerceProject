using Ecommerce.WebApp.Services.CategoriesService;
using Ecommerce.WebApp.Services.ProductsClient;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.WebApp.Extensions
{
    public static class ServiceRegister
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddHttpClient<IProductApi, ProductApi>();
            services.AddHttpClient<ICategoryApi, CategoryApi>();
        }
    }
}
