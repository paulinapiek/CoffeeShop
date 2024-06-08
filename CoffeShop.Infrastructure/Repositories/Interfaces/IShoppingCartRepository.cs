using CoffeeShop.Models;

namespace CoffeShop.Infrastructure.Repositories.Interfaces

{
    public interface IShoppingCartRepository
    {
        void AddToCart(Product product);
        int RemoveFromCart(Product product);
        List<ShoppingCartItem> GetShoppingCartItem();
        void ClearCart();
        decimal GetShoppingCartTotal();
        public List<ShoppingCartItem>? ShoppingCartItems { get; set; }
        public void RemoveAllProductFromCart(int productId);
    }
}