using Microsoft.AspNetCore.Mvc;

namespace Day9WebApp.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TimeCalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TimeCalculator(IFormCollection formCollection)
        {
            int hours = Convert.ToInt32(formCollection["Hours"]);
            int minutes = Convert.ToInt32(formCollection["Minutes"]);
            int seconds = Convert.ToInt32(formCollection["Seconds"]);
            TimeSpan ts = new TimeSpan(0, hours, minutes, seconds);
            double totalSeconds = ts.TotalSeconds;
            ViewBag.TotalSeconds = totalSeconds;
            ViewBag.Seconds = seconds;
            ViewBag.Minutes = minutes;
            ViewBag.Hours = hours;
            return View("TimeCalculatorResult");
        }
    }
}
