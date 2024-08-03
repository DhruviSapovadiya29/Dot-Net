using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class ProductController : Controller
    {
        List<ProductModel> products = new List<ProductModel>()
        { 
            new ProductModel{ ProductID = 1, ProductName = "Laptop", ProductPrice = 50000, ProductCode = "abc", Description="xyz", UserID = 1}
        };
        public IActionResult AddProduct()
        {
            return View();
        }
        public IActionResult ViewProduct()
        {
            return View(products);
        }
        public IActionResult SaveProduct(ProductModel pm)
        {
            if(pm.ProductID == 0)
            {
                pm.ProductID = products.Max(p => p.ProductID) + 1;
                products.Add(pm);
            }
            return View("ViewProduct", products);
        }
    }
}
