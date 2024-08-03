using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class OrderDetailController : Controller
    {
        List<OrderDetailModel> orderDetails = new List<OrderDetailModel>()
        {
            new OrderDetailModel{ OrderDetailID = 1, OrderID = 1, ProductID = 1, Quantity = 2, Amount = 50000, TotalAmount = 100000, UserID = 1 },
        };
        public IActionResult AddOrderDetail()
        {
            return View();
        }
        public IActionResult ViewOrderDetail()
        {
            return View(orderDetails);
        }
        public IActionResult SaveOrderDetail(OrderDetailModel odm)
        {
            if (odm.OrderDetailID == 0) 
            { 
                odm.OrderDetailID = orderDetails.Max(x => x.OrderDetailID) + 1;
                orderDetails.Add(odm);
            }
            return View("ViewOrderDetail", orderDetails);
        }
    }
}
