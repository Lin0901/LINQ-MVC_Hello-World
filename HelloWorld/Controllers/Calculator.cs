using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class Calculator : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string calculator()
        {   
            int a = 0;
            int b = 0;

            string add = "+";
            string subtract = "-";
            string multiply = "*";
            string divide = "/";

            return calculator();
        }
    }
}
