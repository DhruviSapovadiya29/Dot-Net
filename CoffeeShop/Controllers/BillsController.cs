using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class BillsController : Controller
    {
        List<BillsModel> bills = new List<BillsModel>()
        { 
            new BillsModel { BillID = 1, BillNumber = "234", BillDate = new DateTime(2024, 04, 22), OrderID = 1, TotalAmount = 100000, Discount = 10000, NetAmount = 90000, UserID = 1 }
        };
        public IActionResult AddBills()
        {
            return View();
        }
        public IActionResult ViewBills()
        {
            return View(bills);
        }
        public IActionResult SaveBills(BillsModel bm)
        {
            if(bm.BillID == 0)
            {
                bm.BillID = bills.Max(b => b.BillID) + 1;
                bills.Add(bm);
            }
            return View("ViewBills", bills);
        }
    }
}
