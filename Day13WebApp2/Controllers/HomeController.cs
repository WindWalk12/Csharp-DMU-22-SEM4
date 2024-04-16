using Day13WebApp2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Day13WebApp2.Controllers
{
    public class HomeController : Controller
    {
        private List<Person> AllePersoner = new List<Person>();
        public IActionResult VisAlle()
        {
            createAllePersoner();
            return View(AllePersoner);
        }

        public IActionResult VisEn()
        {
            createAllePersoner();
            return View(AllePersoner[2]);
        }

        private void createAllePersoner()
        {
            AllePersoner.Add(new Person("Kalle", 41));
            AllePersoner.Add(new Person("Kalle2", 42));
            AllePersoner.Add(new Person("Kalle3", 43));
        }
    }
}
