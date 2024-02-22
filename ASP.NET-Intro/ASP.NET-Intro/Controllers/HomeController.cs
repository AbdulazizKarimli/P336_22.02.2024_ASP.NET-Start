using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Intro.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}