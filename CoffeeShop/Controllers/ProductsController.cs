using CoffeeShop.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository productRepository;
        public ProductsController(IProductRepository productRepository)
        {
           this.productRepository = productRepository;
        }
        public ActionResult Shop() 
        {
            return View(productRepository.GetAllProducts());
        }

    }
}
