using Ecommerce.WebApp.Models;
using Ecommerce.WebApp.Services.ProductsClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rookie.Ecom.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductApi _productApi;

        public HomeController(ILogger<HomeController> logger, IProductApi productApi)
        {
            _logger = logger;
            _productApi = productApi;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productApi.GetAllProduct();
            var HomeModels = new HomeVm()
            {
                Products = products
            };
            return View(HomeModels);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
