﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.Contracts.Dtos.Product
{
    public class ProductDto
    {
        public Guid ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
        public int Rating { get; set; }
        public bool IsFeatured { get; set; }
        public string ImageUrl { get; set; }

        public string CategoryName { get; set; }

    }
}
