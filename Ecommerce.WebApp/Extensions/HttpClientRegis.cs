using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rookie.Ecom.Contracts.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ecommerce.WebApp.Extensions
{
    public static class HttpClientRegis
    {
        public static void AddCustomHttpClient(this IServiceCollection services, IConfiguration config)
        {
            var configureClient = new Action<IServiceProvider, HttpClient>(async (provider, client) =>
            {
                var httpContextAccessor = provider.GetRequiredService<IHttpContextAccessor>();
               

                client.BaseAddress = new Uri(config[ConfigurationConstants.BACK_END_ENDPOINT]);

              
            });

           
        }
    }
}
