using AutoMapper;
using Rookie.Ecom.Contracts.Dtos.Product;
using Rookie.Ecom.DataAccessor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.Business.Mapping
{
    public class ProductMapperProfile : Profile
    {
        public ProductMapperProfile()
        {
        
            CreateMap<Product, ProductDto>();
            CreateMap<Product, ProductDto>().ReverseMap();

        }
    }
}
