using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
