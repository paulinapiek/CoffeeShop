using CoffeeShop.Models;
using CoffeShop.Infrastructure.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Services
{
    public interface IShoppingCartService
    {
        public (List<ShoppingCartItem> items, decimal count) GetShoppingCartItems();

        public int AddToShoppingCart(int pId);

        public int RemoveFromShoppingCart(int pId);


    }
}




