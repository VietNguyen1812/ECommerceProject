using Rookie.Ecom.Contracts.Dtos;
using Rookie.Ecom.Contracts.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.Contracts.ViewModels
{
    public class CategoryVm
    {
        public IEnumerable<CategoryDto> Categories { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }
    }
}
