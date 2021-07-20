using Rookie.Ecom.Contracts.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.WebApp.Services.ProductsClient
{
    public interface IProductApi
    {
        Task<IEnumerable<ProductDto>> GetAllProduct();

        Task<ProductDto> GetProductById(Guid Id);

        Task<IEnumerable<ProductDto>> GetReleatedProduct(Guid productId);

        Task<IEnumerable<ProductDto>> GetProductByCategory(Guid? categoryId);
    }
}
