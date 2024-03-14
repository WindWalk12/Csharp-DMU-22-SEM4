using Microsoft.AspNetCore.Mvc;

namespace Day9WebApp.Controllers
{
    public class SimpleCalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection formCollection)
        {
            int number1 = Convert.ToInt32(formCollection["Number1"]);
            int number2 = Convert.ToInt32(formCollection["Number2"]);
            string op = Convert.ToString(formCollection["Operator"]);
            double result = 0.0;
            ViewBag.DivideZero = false;
            switch (op)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number1 == 0 || number2 == 0)
                    {
                        ViewBag.DivideZero = true;
                        break;
                    }
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("Something wrong");
                    break;
            }
            ViewBag.Result = result.ToString();
            ViewBag.Number1 = number1.ToString();
            ViewBag.Number2 = number2.ToString();
            return View();
        }
    }
}
