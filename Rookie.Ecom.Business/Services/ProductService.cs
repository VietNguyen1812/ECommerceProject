using Rookie.Ecom.Business.Interfaces;
using Rookie.Ecom.Contracts;
using Rookie.Ecom.Contracts.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.Business.Services
{
    public class ProductService : IProductService
    {
        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> GetProductByCategory(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> GetRelatedProduct(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResponseModel<ProductDto>> PagedQueryAsync(string name, int page, int limit)
        {
            throw new NotImplementedException();
        }
    }
}
