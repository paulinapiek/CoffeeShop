using CoffeeShop.Models;
using CoffeShop.Infrastructure.Repositories.Interfaces;
using CoffeShop.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Web.Controllers;

[Authorize]
public class OrdersController : Controller
{
    private IOrderService orderService;
    public OrdersController(IOrderService orderService)
    {
        this.orderService = orderService;
        
    }
    public IActionResult Checkout()
    {
        
        return View();
    }
    [HttpPost]
    public IActionResult Checkout(Order order)
    {
        orderService.Checkout(order);
        HttpContext.Session.SetInt32("CartCount", 0);
        return RedirectToAction("CheckoutComplete");
    }
    public IActionResult CheckoutComplete() 
    { 
        return View();  
    }


}
