using CoffeShop.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        private IShoppingCartService shoppingCartService;
       
        public ShoppingCartController(IShoppingCartService shoppingCartService)
        {
            this.shoppingCartService = shoppingCartService;
            

        }
        public IActionResult Index()
        {
            var result = shoppingCartService.GetShoppingCartItems();

            ViewBag.CartTotal = result.count;
            return View(result.items);
        }
        public RedirectToActionResult AddToShoppingCart(int pId)
        {
            var result= shoppingCartService.AddToShoppingCart(pId);

            if (result >=0)
            {
                HttpContext.Session.SetInt32("CartCount", result);


            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromShoppingCart(int pId)
        {
            var result = shoppingCartService.RemoveFromShoppingCart(pId);
            if (result >=0)
            {
                HttpContext.Session.SetInt32("CartCount", result);
            }
            return RedirectToAction("Index");
        }
    }
} 
