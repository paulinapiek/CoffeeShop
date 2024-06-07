﻿using CoffeeShop.Models;
using CoffeShop.Infrastructure.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Web.Controllers;

[Authorize]
public class OrdersController : Controller
{
    private IOrderRepository orderRepository;
    private IShoppingCartRepository shoppingCartRepository;
    public OrdersController(IOrderRepository orderRepository, IShoppingCartRepository shoppingCartRepository)
    {
        this.orderRepository = orderRepository;
        this.shoppingCartRepository = shoppingCartRepository;
    }
    public IActionResult Checkout()
    {
        
        return View();
    }
    [HttpPost]
    public IActionResult Checkout(Order order)
    {
        orderRepository.PlaceOrder(order);
        shoppingCartRepository.ClearCart();
        HttpContext.Session.SetInt32("CartCount", 0);
        return RedirectToAction("CheckoutComplete");
    }
    public IActionResult CheckoutComplete() 
    { 
        return View();  
    }


}
