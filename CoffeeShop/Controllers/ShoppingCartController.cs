using CoffeeShop.Models.Interfaces;
using CoffeeShop.Models.Services;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private IShoppingCartRepository shoppingcCartRepository;
        private IProductRepository productRepository;
        public ShoppingCartController(IShoppingCartRepository shoppingCartRepositiry, IProductRepository productRepository)
        {
            this.shoppingcCartRepository = shoppingCartRepositiry;
            this.productRepository = productRepository;

        }
        public IActionResult Index()
        {
            var items = shoppingcCartRepository.GetShoppingCartItem();
            shoppingcCartRepository.ShoppingCartItems = items;
           ViewBag.CartTotal= shoppingcCartRepository.GetShoppingCartTotal();
            return View(items);
        }
        public RedirectToActionResult AddToShoppingCart(int pId)
        {
            var products = productRepository.GetAllProducts();
            var product= products.FirstOrDefault(p=>p.Id == pId);
            if(product != null)
            {
                shoppingcCartRepository.AddToCart(product);
               int cartCount= shoppingcCartRepository.GetShoppingCartItem().Count();
                HttpContext.Session.SetInt32("CartCount", cartCount);
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromShoppingCart(int pId)
        {
            var product = productRepository.GetAllProducts().FirstOrDefault(p => p.Id == pId);
            if (product != null)
            {
                shoppingcCartRepository.RemoveFromCart(product);
                int cartCount = shoppingcCartRepository.GetShoppingCartItem().Count();
                HttpContext.Session.SetInt32("CartCount", cartCount);
            }
            return RedirectToAction("Index");
        }
    }
} 
