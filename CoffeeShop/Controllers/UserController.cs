using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class UserController : Controller
    {
        List<UserModel> users = new List<UserModel>()
        { 
            new UserModel{ UserID = 1, UserName = "Flint", Email = "flint@gmail.com", Password="flint123", MobileNo = "9876543210", Address = "Osaka, Japan", IsActive = true },
        };
        public IActionResult AddUser()
        {
            return View();
        }
        public IActionResult ViewUser()
        {
            return View(users);
        }
        public IActionResult SaveUser(UserModel um)
        {
            if(um.UserID == 0)
            {
                um.UserID = users.Max(u => u.UserID) + 1;
                users.Add(um);
            }
            return View("ViewUser", users);
        }
    }
}
