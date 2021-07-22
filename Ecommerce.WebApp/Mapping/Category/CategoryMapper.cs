using AutoMapper;
using Rookie.Ecom.Contracts.Dtos;
using Rookie.Ecom.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.WebApp.Mapping.Category
{
    public class CategoryMapper : Profile
    {
        public CategoryMapper()
        {
            CreateMap<CategoryDto, CategoryVm>().ReverseMap();
        }
    }
}
