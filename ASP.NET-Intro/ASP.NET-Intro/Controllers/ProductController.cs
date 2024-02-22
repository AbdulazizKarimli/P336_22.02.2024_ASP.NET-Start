using ASP.NET_Intro.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Intro.Controllers;

public class ProductController : Controller
{
    public IActionResult Index()
    {
        List<Product> products = new List<Product>()
        {
            new Product() { Id = 1, Name = "Playstation 4 Slim", Price = 450, Description = "Ela veziyyetdedir"},
            new Product() { Id = 2, Name = "Et ceken mashin", Price = 400, Description = "Anlatmaya gerek yok"},
            new Product() { Id = 3, Name = "Mikrodalga", Price = 1000, Description = "Agillidir."},
        };

        return View(products);
    }

    //public IActionResult Test()
    //{
    //    //List<string> productNames = new List<string>()
    //    //{
    //    //    "Playstation 4 Slim", "Et ceken mashin", "Mikro dalgali soba"
    //    //};
    //    string name = "Kamal";
    //    TempData["Name"] = name;

    //    return RedirectToAction("Index");
    //}

    public IActionResult Detail(int id)
    {
        //ViewBag.Id = id;
        //ViewData["id"] = id;
        TempData["id"] = id;

        return View();
    }
}