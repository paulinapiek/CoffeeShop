using CoffeeShop.Models;
using CoffeShop.Infrastructure.Repositories.Interfaces;

namespace CoffeShop.Services
{
    public class ShoppingCartService : IShoppingCartService
    {

        private IShoppingCartRepository shoppingcCartRepository;
        private IProductRepository productRepository;
        public ShoppingCartService(IShoppingCartRepository shoppingCartRepositiry, IProductRepository productRepository)
        {
            this.shoppingcCartRepository = shoppingCartRepositiry;
            this.productRepository = productRepository;

        }
        public ( List<ShoppingCartItem> items, decimal count ) GetShoppingCartItems()
        {
            var items = shoppingcCartRepository.GetShoppingCartItem();
            shoppingcCartRepository.ShoppingCartItems = items;
           var CartTotal = shoppingcCartRepository.GetShoppingCartTotal();
            return new (items, CartTotal);
        }
        public int AddToShoppingCart(int pId)
        {
            var products = productRepository.GetAllProducts();
            var product = products.FirstOrDefault(p => p.Id == pId);
            if (product != null)
            {
                shoppingcCartRepository.AddToCart(product);
                int cartCount = shoppingcCartRepository.GetShoppingCartItem().Count();
                 return (cartCount);
            }
            return -1;
        }
        public int RemoveFromShoppingCart(int pId)
        {
            var product = productRepository.GetAllProducts().FirstOrDefault(p => p.Id == pId);
            if (product != null)
            {
                shoppingcCartRepository.RemoveFromCart(product);
                int cartCount = shoppingcCartRepository.GetShoppingCartItem().Count();
                return ( cartCount);
            }
            return -1;
        }
    }
}
