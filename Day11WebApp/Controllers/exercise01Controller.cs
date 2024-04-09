using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Day11WebApp.Controllers
{
    public class exercise01Controller : Controller
    {
        List<SelectListItem> countries = new List<SelectListItem>();
        public IActionResult Index(string Countries)
        {   
            if (HttpContext.Session.GetString("countries") == null)
            {
                countries.Add(new SelectListItem { Text = "Denmark", Value = "DK" });
                countries.Add(new SelectListItem { Text = "United Kingdom", Value = "UK" });
                countries.Add(new SelectListItem { Text = "China", Value = "CN" });
                HttpContext.Session.SetString("countries", JsonConvert.SerializeObject(countries));

            } else
            {
                countries = JsonConvert.DeserializeObject<List<SelectListItem>>(HttpContext.Session.GetString("countries"));
            }
            ViewBag.countries = countries;
            ViewBag.countryCode = Countries;
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection formCollection)
        {
            string country = Convert.ToString(formCollection["country"]);
            string countryCode = Convert.ToString(formCollection["countryCodeX"]);
            countries = JsonConvert.DeserializeObject<List<SelectListItem>>(HttpContext.Session.GetString("countries"));
            countries.Add(new SelectListItem { Text = country, Value = countryCode });
            HttpContext.Session.SetString("countries", JsonConvert.SerializeObject(countries));
            ViewBag.countries = countries;
            return View();
        }
    }
}
