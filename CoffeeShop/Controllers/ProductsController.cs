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
        public IActionResult Detail(int id)
            {
     //if product id doesn't exist it will returned the information that is not found http error 404
            var product = productRepository.GetProductDetail(id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
