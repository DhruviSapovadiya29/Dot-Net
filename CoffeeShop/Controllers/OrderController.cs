using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class OrderController : Controller
    {
        List<OrderModel> orders = new List<OrderModel>()
        { 
            new OrderModel{ OrderID = 1, OrderDate = new DateTime(2023, 7, 20), CustomerID = 1, PaymentMode = "Cash", TotalAmount = 100000, ShippingAddress = "abc", UserID = 1  },
        };
        public IActionResult AddOrder()
        {
            return View();
        }
        public IActionResult ViewOrder()
        {
            return View(orders);
        }
        public IActionResult SaveOrder(OrderModel om)
        {
            if(om.OrderID == 0)
            {
                om.OrderID = orders.Max(o => o.OrderID) + 1;
                orders.Add(om);
            }
            return View("ViewOrder", orders);
        }
    }
}
