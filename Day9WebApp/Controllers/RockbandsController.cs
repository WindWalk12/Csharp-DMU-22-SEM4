using Microsoft.AspNetCore.Mvc;

namespace Day9WebApp.Controllers
{
    public class RockbandsController : Controller
    {
        public IActionResult Index()
        {
            List<string> RockbandList = new List<string>
            {
                "Led Zeppelin",
                "The Rolling Stones",
                "Pink Floyd",
                "Queen",
                "The Beatles",
                "The Who",
                "AC/DC",
                "Guns N' Roses",
                "Nirvana",
                "The Doors"
            };
            ViewBag.Rockbands = RockbandList;
            return View();
        }
    }
}
