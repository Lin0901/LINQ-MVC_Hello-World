using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HelloWorld : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SayHello(string age)
        {
            string name = "Lin";
            string customMessage = $"Welcome, {name}. Your age is {age}";

            return View();
        }

        public IActionResult Calculator(int firstOperant, int secondOperant, string operation)
        {
            int result = 0;
            string verb = "";

            try 
            {
                switch (operation)
                {
                    case "add":
                        {
                            result = firstOperant + secondOperant;
                            verb = "plus";
                            break;
                        }
                    case "subtract":
                        {
                            result = firstOperant - secondOperant;
                            verb = "minus";
                            break;
                        }
                    case "multiply":
                        {
                            result = firstOperant * secondOperant;
                            verb = "multiply by";
                            break;
                        }
                    case "divide":
                        {
                            result = firstOperant / secondOperant;
                            verb = "divided by";
                            break;
                        }
                };

                ViewData["result"] = result;
                ViewData["verb"] = verb;
                ViewData["firstNumber"] = firstOperant;
                ViewData["secondNumber"] = secondOperant;

                return View();

            } catch(Exception ex)
            {
                return View("Error");
            }

            

            
        }
        
    }
}
