using Ecommerce.WebApp.Services.ProductsClient;
using Microsoft.AspNetCore.Mvc;
using Rookie.Ecom.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.WebApp.Controllers
{
    public class ProductController :Controller
    {
       private readonly IProductApi _productsApi;

       public ProductController(IProductApi productsApi)
        {
            _productsApi = productsApi;
        }

        public async Task<IActionResult> Detail(Guid productId)
        {
            var products = await _productsApi.GetProductById(productId);

            var relatedProducts = await _productsApi.GetReleatedProduct(productId);
            if (products == null)
                return BadRequest("Không tìm thấy sản phầm");

            var vm = new ProductVm()
            {
                Product = products,
                ListProduct = relatedProducts
            };

            return View(vm);
        }
    }
}
