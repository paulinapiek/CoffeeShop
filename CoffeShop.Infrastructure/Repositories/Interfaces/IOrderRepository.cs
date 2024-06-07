using CoffeeShop.Models;

namespace CoffeShop.Infrastructure.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void PlaceOrder(Order order);

    }
}
