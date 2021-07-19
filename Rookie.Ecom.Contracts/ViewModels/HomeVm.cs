using Rookie.Ecom.Contracts.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.Contracts.ViewModels
{
    class HomeVm
    {
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
