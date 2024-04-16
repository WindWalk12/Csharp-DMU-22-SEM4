using Microsoft.AspNetCore.Mvc;

namespace Day13WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Sale()
        {
            return View();
        }

        public IActionResult MoreSales()
        {
            return View();
        }

        public IActionResult Buy()
        {
            return View();
        }

        public IActionResult BuyAndSell()
        {
            return View();
        }
    }
}
