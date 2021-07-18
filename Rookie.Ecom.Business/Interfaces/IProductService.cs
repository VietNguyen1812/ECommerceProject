using Rookie.Ecom.Contracts;
using Rookie.Ecom.Contracts.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.Business.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllAsync();

        Task<PagedResponseModel<ProductDto>> PagedQueryAsync(string name, int page, int limit);

        Task<ProductDto> GetByIdAsync(Guid id);

        Task DeleteAsync(Guid id);

        Task<ProductDto> AddAsync(ProductDto productId);
        Task UpdateAsync(ProductDto productId);
        Task<IEnumerable<ProductDto>> GetProductByCategory(Guid categoryId);

        Task<IEnumerable<ProductDto>> GetRelatedProduct(Guid productId);

    }
}
