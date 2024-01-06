using CoffeeShop.Models.Interfaces;
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

        }
        public IActionResult Index()
        {
            var items = shoppingcCartRepository.GetShoppingCartItem();
            shoppingcCartRepository.ShoppingCartItems = items;
            return View(items);
        }
        public RedirectToActionResult AddToShoppimgCart(int pId)
        {
           var product= productRepository.GetAllProducts().FirstOrDefault(p=>p.Id == pId);
            if(product != null)
            {
                shoppingcCartRepository.AddToCart(product);
            }return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromShoppingCart(int pId)
        {
            var product = productRepository.GetAllProducts().FirstOrDefault(p => p.Id == pId);
            if (product != null)
            {
                shoppingcCartRepository.RemoveFromCart(product);
            }
            return RedirectToAction("Index");
        }
    }
} 
