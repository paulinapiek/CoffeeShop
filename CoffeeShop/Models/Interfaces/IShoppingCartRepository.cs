namespace CoffeeShop.Models.Interfaces
    
{
    public interface IShoppingCartRepository
    {
        void AddToCart(Interfaces.Product product);
        int RemoveFromCart(Interfaces.Product product);
        List<ShoppingCartItem> GetShoppingCartItem();
        void ClearCart();
        decimal GetShoppingCartTotal();
        public List<ShoppingCartItem> ?ShoppingCartItems { get; set; }
    }
}