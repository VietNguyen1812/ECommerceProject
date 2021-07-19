using AutoMapper;
using EnsureThat;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rookie.Ecom.Business.Interfaces;
using Rookie.Ecom.Contracts.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Ecom.Identity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        => await _productService.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<ProductDto> GetByIdAsync(Guid id)
         => await _productService.GetByIdAsync(id);

        //GetRelatedProduct
        [HttpGet("latest/{productId}")]
        public async Task<IEnumerable<ProductDto>> GetRelatedProduct(Guid productId)
        => await _productService.GetRelatedProduct(productId);

        [HttpGet("GetProductByCategory/{categoryId}")]
        public async Task<IEnumerable<ProductDto>> GetProductByCategory(Guid categoryId)
        => await _productService.GetProductByCategory(categoryId);

        [HttpPost]
        public async Task<ActionResult<ProductDto>> CreateAsnyc([FromBody] ProductDto products)
        {
            Ensure.Any.IsNotNull(products, nameof(ProductDto));
            var product = await _productService.AddAsync(products);
            return product;
        }

        [HttpPut]
        public async Task<ActionResult<ProductDto>> UpdateAsync([FromBody] ProductDto products)
        {
            Ensure.Any.IsNotNull(products, nameof(ProductDto));
            //Ensure.Any.IsNotNull(products.ProductId, nameof(ProductDto));

            await _productService.UpdateAsync(products);
            return BadRequest();

           
            //return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync([FromBody] Guid id)
        {
            var productId = await _productService.GetByIdAsync(id);
            Ensure.Any.IsNotNull(productId, nameof(ProductDto));
            await _productService.DeleteAsync(id);
            return NoContent();
        }

    }
}
