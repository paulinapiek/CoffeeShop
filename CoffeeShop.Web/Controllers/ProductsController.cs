using CoffeeShop.Models;
using CoffeShop.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace CoffeeShop.Web.Controllers
{
    public class ProductsController : Controller
    {
        private IProductService productService;
        public ProductsController(IProductService productService)
        {
           this.productService = productService;
        }
        public ActionResult Shop() 
        {
            return View(productService.GetAllProducts());
        }
        public IActionResult Detail(int id)
            {
     //if product id doesn't exist it will returned the information that is not found http error 404
            var product = productService.GetProductDetail(id);
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
            productService.Create(product);
            return RedirectToAction("Shop");

        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id) 
        {
           productService.Delete(id);
            return RedirectToAction("Shop");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
       [Authorize(Roles = "Admin")]

        public IActionResult Edit(Product product)

        {
            productService.Edit(product);
            return RedirectToAction("Detail",new { id = product.Id });

        }
        [HttpGet]
       [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id) 
        {
            var product = productService.GetProductDetail(id);
            return View(product);
        }
    }
}
