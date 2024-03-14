using Day9WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day9WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string name = "Gaston";
            int age = 26;
            DateTime birthday = DateTime.Now;
            ViewBag.name = name;
            ViewBag.age = age;
            ViewBag.birthday = birthday;
            return View(new Person(name, age, birthday));
        }
    }
}
