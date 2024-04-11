using Day12WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day12WebApp.Controllers
{
    public class PersonController : Controller
    {
        [Route("hus")]
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View();
        }

        [Route("Find/{fornavn}/{efternavn}")]
        public ActionResult Find(String fornavn, String efternavn)
        {
            ViewBag.fornavn = fornavn;
            ViewBag.efternavn = efternavn;
            return View("Person");
        }

        [Route("create")]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        [Route("personcreatedcollection")]
        public ActionResult PersonCreatedCollection(IFormCollection formCollection)
        {
            string fornavn = Convert.ToString(formCollection["fornavn"]);
            string efternavn = Convert.ToString(formCollection["efternavn"]);
            int alder = Convert.ToInt32(formCollection["alder"]);
            Person person = new Person(fornavn, efternavn, alder);
            return View("PersonCreated", person);
        }

        [HttpPost]
        [Route("PersonCreatedSimpleTyper")]
        public ActionResult PersonCreatedSimpleTyper(string fornavn, string efternavn, int alder)
        {
            Person person = new Person(fornavn, efternavn, alder);
            return View("PersonCreated", person);
        }

        [HttpPost]
        [Route("PersonCreatedModel")]
        public ActionResult PersonCreatedModel(Person person)
        {
            return View("PersonCreated", person);
        }
    }
}
