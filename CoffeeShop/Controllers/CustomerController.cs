using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class CustomerController : Controller
    {
        List<CustomerModel> customers = new List<CustomerModel>()
        {
            new CustomerModel{ CustomerID = 1, CustomerName = "Zox", HomeAddress = "Saitama Prefecture, Japan", Email = "zox@gmail.com", MobileNo = "9876543210", GSTNo = "12345", CityName = "Saitama", PinCode = "123456", NetAmount = 90000, UserID = 1 },
            new CustomerModel{ CustomerID = 2, CustomerName = "Dhruvi", HomeAddress = "palace Prefecture, surat", Email = "dhruvi2@gmail.com", MobileNo = "3476543210", GSTNo = "34509", CityName = "rajkot", PinCode = "36005", NetAmount = 50000, UserID = 2 }
        };
        public IActionResult AddCustomer()
        {
            return View();
        }
        public IActionResult ViewCustomer()
        {
            return View(customers);
        }
        public IActionResult SaveCustomer(CustomerModel cm)
        {
            if(cm.CustomerID == 0)
            {
                cm.CustomerID = customers.Max(c => c.CustomerID) + 1;
                customers.Add(cm);
            }
            return View("ViewCustomer", customers);
        }
    }
}
