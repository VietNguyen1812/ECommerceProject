using Rookie.Ecom.Contracts.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.Contracts.ViewModels
{
    public class ProductVm
    {
        public ProductDto Product { get; set; }
        public Guid?  CategoryId { get; set; }
        public IEnumerable<ProductDto> ListProduct { get; set; }
    }
}
