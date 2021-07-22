using AutoMapper;
using Rookie.Ecom.Contracts.Dtos.Product;
using Rookie.Ecom.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.WebApp.Mapping
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<ProductDto, ProductVm>().ReverseMap();
        }
    }
}
