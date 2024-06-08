using CoffeeShop.Models;
using CoffeShop.Infrastructure.Repositories.Interfaces;

namespace CoffeShop.Services
{
    public class OrderService : IOrderService
    {

        private IOrderRepository orderRepository;
        private IShoppingCartRepository shoppingCartRepository;
        public OrderService(IOrderRepository orderRepository, IShoppingCartRepository shoppingCartRepository)
        {
            this.orderRepository = orderRepository;
            this.shoppingCartRepository = shoppingCartRepository;
        }
        public void Checkout(Order order)
        {
            orderRepository.PlaceOrder(order);
            shoppingCartRepository.ClearCart();
                  
        }

    }
}
