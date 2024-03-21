using Day10WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day10WebApp.Controllers
{
    public class Exercise02Controller : Controller
    {
        public IActionResult Index()
        {
            List<string> numbers = new List<string>
            {
                "87654321",
                "28475638",
                "72837461"
            };
            List<Person> persons = new List<Person>();
            Person p1 = new Person("Lars", "Hjul", "Andegade 33", "7621", "Andegaarden", numbers);
            p1.Birthday = new DateTime(1996, 03, 17);
            Person p2 = new Person("Gunner", "Hjul", "Andegade 33", "7621", "Andegaarden", numbers);
            p2.Birthday = DateTime.Now;
            Person p3 = new Person("Sine", "Hjul", "Andegade 33", "7621", "Andegaarden", numbers);
            p3.Birthday = new DateTime(1998, 03, 17);
            Person p4 = new Person("Emily", "Hjul", "Andegade 33", "7621", "Andegaarden", numbers);
            p4.Birthday = new DateTime(1999, 03, 17);
            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p3);
            persons.Add(p4);
            ViewBag.Persons = persons;
            return View();
        }
    }
}
