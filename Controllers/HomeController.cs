using Microsoft.AspNetCore.Mvc;

namespace Bibliotec_MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}
