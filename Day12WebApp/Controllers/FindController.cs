using Microsoft.AspNetCore.Mvc;

namespace Day12WebApp.Controllers
{
    public class FindController : Controller
    {
        [Route("Ole")]
        public IActionResult Ole(string fornavn, string efternavn)
        {
            return View("Index");
        }
    }
}
