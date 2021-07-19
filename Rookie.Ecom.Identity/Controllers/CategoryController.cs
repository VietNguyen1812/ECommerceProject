using EnsureThat;
using Microsoft.AspNetCore.Mvc;
using Rookie.Ecom.Business.Interfaces;
using Rookie.Ecom.Contracts;
using Rookie.Ecom.Contracts.Constants;
using Rookie.Ecom.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rookie.Ecom.Identity.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController (ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("{id}")]
        public async Task<CategoryDto> GetByIdAsync(Guid id)=> await _categoryService.GetByIdAsync(id);
           
        

        [HttpGet]
        public async Task<IEnumerable<CategoryDto>> GetAsync()=> await _categoryService.GetAllAsync();

        [HttpGet("find")]
        public async Task<PagedResponseModel<CategoryDto>>FindAsync(string name, int page = 1, int limit = 10)
            => await _categoryService.PagedQueryAsync(name, page, limit);

        [HttpPost]
        public async Task<ActionResult<CategoryDto>> CreateAsync([FromBody] CategoryDto categoryDto)
        {
            Ensure.Any.IsNotNull(categoryDto, nameof(categoryDto));
            var asset = await _categoryService.AddAsync(categoryDto);
            return Created(Endpoints.Category, asset);
        }
        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] CategoryDto categoryDto)
        {
            Ensure.Any.IsNotNull(categoryDto, nameof(categoryDto));
            Ensure.Any.IsNotNull(categoryDto.CategoryId, nameof(categoryDto));
            await _categoryService.UpdateAsync(categoryDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAssetAsync([FromRoute] Guid id)
        {
            var categoryDto = await _categoryService.GetByIdAsync(id);
            Ensure.Any.IsNotNull(categoryDto, nameof(categoryDto));
            await _categoryService.DeleteAsync(id);
            return NoContent();
        }





    }
}
