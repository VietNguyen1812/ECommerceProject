using AutoMapper;
using Rookie.Ecom.Business.Interfaces;
using Rookie.Ecom.Contracts;
using Rookie.Ecom.Contracts.Dtos.Product;
using Rookie.Ecom.DataAccessor.Data;
using Rookie.Ecom.DataAccessor.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.Business.Services
{
    public class ProductService : IProductService
    {

        private readonly IBaseRepository<Product> _baseRepository;
        private readonly IMapper _mapper;
        private readonly EcommerceDbContext _dbContext;

        public ProductService(IBaseRepository<Product> baseRepository, IMapper mapper, EcommerceDbContext dbContext)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public async Task<ProductDto> AddAsync(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);

            var item = await _baseRepository.AddAsync(product);
            return _mapper.Map<ProductDto>(item);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _baseRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var products = await _baseRepository.GetAllAsync();
            return _mapper.Map<List<ProductDto>>(products);
        }

        public async Task<ProductDto> GetByIdAsync(Guid id)
        {
            var products = await _baseRepository.GetByIdAsync(id);

            return _mapper.Map<ProductDto>(products);
        }

        public async Task<IEnumerable<ProductDto>> GetProductByCategory(Guid categoryId)
        {
            var products = await _dbContext.Products.Include(x => x.Category)
                                                   .Where(x => x.CategoryId == categoryId)
                                                   .OrderBy(x => x.Name)
                                                   .AsNoTracking()
                                                   .ToListAsync();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDto>()
                                                            .ForMember(dest => dest.CategoryName, opt => opt
                                                             .MapFrom(s => s.Category.CategoryName))
                                                 ).CreateMapper();

            var objDTO = new List<ProductDto>();

            foreach (var item in products)
            {
                objDTO.Add(mapper.Map<ProductDto>(item));
            }

            return objDTO;
        }

        public async Task<IEnumerable<ProductDto>> GetRelatedProduct(Guid productId)
        {
            var Product = await _dbContext.Products.FirstOrDefaultAsync(m => m.ProductId == productId);
            var objList = await _dbContext.Products.Include(m => m.Category)
                                                   .Where(m => m.CategoryId == Product.CategoryId && Product.ProductId == productId && m.ProductId != productId)
                                                   .OrderBy(m => m.Name)
                                                   .AsNoTracking()
                                                   .ToListAsync();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(s => s.Category.CategoryName))
            )
            .CreateMapper();

            var objDTO = new List<ProductDto>();

            foreach (var item in objList)
            {
                objDTO.Add(mapper.Map<ProductDto>(item));
            }
            return objDTO;
        }

        public async Task<PagedResponseModel<ProductDto>> PagedQueryAsync(string name, int page, int limit)
        {
            var query = _baseRepository.Entities;

            query = query.Where(x => string.IsNullOrEmpty(name) || x.Name.Contains(name));

            query = query.OrderBy(x => x.Name);

            var assets = await query
                .AsNoTracking()
                .PaginateAsync(page, limit);
            return new PagedResponseModel<ProductDto>
            {
                CurrentPage = assets.CurrentPage,
                TotalPages = assets.TotalPages,
                TotalItems = assets.TotalItems,
                Items = _mapper.Map<IEnumerable<ProductDto>>(assets.Items)
            };
        }

        public async Task UpdateAsync(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            await _baseRepository.UpdateAsync(product);
        }
    }
}
