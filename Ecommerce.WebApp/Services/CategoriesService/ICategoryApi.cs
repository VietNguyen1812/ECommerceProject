using Rookie.Ecom.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.WebApp.Services.CategoriesService
{
    public interface ICategoryApi
    {
        Task<IEnumerable<CategoryDto>> GetAllCategory();

        Task<CategoryDto> GetCategoryById(Guid Id);
    }
}
