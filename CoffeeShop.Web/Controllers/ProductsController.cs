using CoffeeShop.Models;
using CoffeShop.Infrastructure.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace CoffeeShop.Web.Controllers
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
        [Authorize(Roles = "Admin")]
        public IActionResult Create() 
        {
            return View() ;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]

        public IActionResult Create(Product product)

        {
            productRepository.AddProduct(product);
            return RedirectToAction("Shop");

        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id) 
        {
           productRepository.DeleteProduct(id);
            return RedirectToAction("Shop");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
       [Authorize(Roles = "Admin")]

        public IActionResult Edit(Product product)

        {
            productRepository.EditProduct(product);
            return RedirectToAction("Detail",new { id = product.Id });

        }
        [HttpGet]
       [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id) 
        {
            var k = this.HttpContext.User;
            var product = productRepository.GetProductDetail(id);
            return View(product);
        }
    }
}
