using Microsoft.AspNetCore.Mvc;

namespace Day11WebApp.Controllers
{
    public class exercise03Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection formCollection)
        {
            ViewBag.name = formCollection["fullname"];
            ViewBag.room = formCollection["roomnumber"];
            ViewBag.order = formCollection["menuitem"].ToString().Replace(",", ", ");
            ViewBag.date = formCollection["time"];
            return View("receipt");
        }
    }
}
