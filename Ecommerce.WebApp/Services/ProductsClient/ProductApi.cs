using Newtonsoft.Json;
using Rookie.Ecom.Contracts.Constants;
using Rookie.Ecom.Contracts.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ecommerce.WebApp.Services.ProductsClient
{
    public class ProductApi :IProductApi
    {

        private readonly IHttpClientFactory _clientFactory;

        public ProductApi(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async  Task<IEnumerable<ProductDto>> GetAllProduct()
        {
            var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);

            var respone = await client.GetAsync("api/Products");

            respone.EnsureSuccessStatusCode();

            var body = await respone.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<ProductDto>>(body);
        }

        public async Task<IEnumerable<ProductDto>> GetProductByCategory(Guid? categoryId)
        {
            var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);

            var respone = await client.GetAsync($"api/Products/GetProductByCategory\\{categoryId}");

            respone.EnsureSuccessStatusCode();

            var body = await respone.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<ProductDto>>(body);
        }

        public async Task<ProductDto> GetProductById(Guid Id)
        {
            var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);

            var respone = await client.GetAsync($"api/Products\\{Id}");

            respone.EnsureSuccessStatusCode();

            var body = await respone.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ProductDto>(body);
        }

        public async Task<IEnumerable<ProductDto>> GetReleatedProduct(Guid productId)
        {
            var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);

            var respone = await client.GetAsync($"api/Products/GetRelatedProduct\\{productId}");


            respone.EnsureSuccessStatusCode();

            var body = await respone.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<ProductDto>>(body);
        }
    }
}
