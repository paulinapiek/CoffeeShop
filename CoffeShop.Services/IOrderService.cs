using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Services
{
    public interface IOrderService
    {
        void Checkout(Order order);
    }
}
