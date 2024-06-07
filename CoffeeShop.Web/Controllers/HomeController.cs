using CoffeeShop.Models;
using CoffeShop.Infrastructure.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShop.Web.Controllers
{
    public class HomeController : Controller
        
    {
        private IProductRepository productRepository; 
        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
           
        private readonly ILogger<HomeController> _logger;

     

        public IActionResult Index()
        {
            
            return View(productRepository.GetTrendingProducts());
           
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