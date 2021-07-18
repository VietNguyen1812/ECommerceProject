using Rookie.Ecom.Contracts.Dtos.Product;
using System;
using System.Collections.Generic;

namespace Rookie.Ecom.Contracts.Dtos
{
    public class CategoryDto
    {
        public Guid? CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }


        public IEnumerable<ProductDto> Products { get; set; }
    }
}
