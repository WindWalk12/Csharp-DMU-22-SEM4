using Day11WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Day11WebApp.Controllers
{
    public class exercise02Controller : Controller
    {
        ParkingTicketMachine ptm;
        public IActionResult Index()
        {
            ptm = new ParkingTicketMachine();
            HttpContext.Session.SetString("ptm", JsonConvert.SerializeObject(ptm));
            ViewBag.cancel = false;
            ViewBag.amount = 0;
            return View(ptm);
        }

        [HttpPost]
        public IActionResult Index(IFormCollection formCollection)
        {
            ptm = JsonConvert.DeserializeObject<ParkingTicketMachine>(HttpContext.Session.GetString("ptm"));
            string action = Convert.ToString(formCollection["action"]);
            if (action != null)
            {
                if (action == "cancel")
                {
                    ViewBag.cancel = true;
                    ViewBag.amount = ptm.AmountInserted;
                    ptm = new ParkingTicketMachine();
                    HttpContext.Session.SetString("ptm", JsonConvert.SerializeObject(ptm));
                } else
                {
                    return View("confirm", ptm);
                }
            } else
            {
                int coinInserted = Convert.ToInt32(formCollection["coin"]);
                ptm.InsertCoin(coinInserted + ptm.AmountInserted);
                ViewBag.amount = ptm.AmountInserted;
                HttpContext.Session.SetString("ptm", JsonConvert.SerializeObject(ptm));
            }
            return View(ptm);
        }
    }
}
