
using Newtonsoft.Json;
using Rookie.Ecom.Contracts.Constants;
using Rookie.Ecom.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ecommerce.WebApp.Services.CategoriesService
{
    public class CategoryApi : ICategoryApi
    {
        private readonly IHttpClientFactory _clientFactory;

        public CategoryApi(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }


        public async Task<IEnumerable<CategoryDto>> GetAllCategory()
        {
            var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var respone = await client.GetAsync("api/Categories");
            respone.EnsureSuccessStatusCode();

            var categories = await respone.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<CategoryDto>>(categories);
        }

        public async Task<CategoryDto> GetCategoryById(Guid Id)
        {
            var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);

            var respone = await client.GetAsync($"api/Categories\\{Id}");

            respone.EnsureSuccessStatusCode();

            var categories = await respone.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<CategoryDto>(categories);
        }
    }
}
