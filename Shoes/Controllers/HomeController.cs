using Microsoft.AspNetCore.Mvc;
using Shoes.Models;
using System.Diagnostics;

namespace Shoes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Shoe shoe)
        {
            return View(shoe);
        }

        [HttpPost]
        public IActionResult Validate(Shoe shoe)
        {
            if (!ModelState.IsValid || shoe.Material == null || shoe.Size > 100 || shoe.Size < 2 || shoe.Material.Length < 2 || shoe.Material.Length > 10)
            {
                return View("ValidationError");
            }
            else
            {
                return View("Confirmation", shoe);
            }
        }
    }
}