using Ecommerce.WebApp.Services.ProductsClient;
using Microsoft.AspNetCore.Mvc;
using Rookie.Ecom.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.WebApp.Controllers
{
    public class CategoryController :Controller
    {
        private readonly IProductApi _productApiClient;

        public CategoryController(IProductApi productApiClient)
        {
            _productApiClient = productApiClient;
        }

        public async Task<IActionResult> Index(Guid? categoryId)
        {
            var listProduct = await _productApiClient.GetProductByCategory(categoryId);

            var vm = new CategoryVm()
            {
                Products = listProduct
            };
            return View(vm);
        }
    }
}
