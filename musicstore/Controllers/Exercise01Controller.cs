using Microsoft.AspNetCore.Mvc;
using musicstore.Models;

namespace musicstore.Controllers
{
    public class Exercise01Controller : Controller
    {
        public IActionResult Index()
        {
            Book b = new Book("Drage krigeren", 99.99, "Den eneste ene", "Drage udgiveren", 1997, "uwegwbg7326fewgw");
            MusicCD m = new MusicCD("Drage sangen", 99.99, "Den eneste ene", "Drage label", 1997);
            m.addTrack("Drage Dansen");
            m.addTrack("Drageleg i Månens Lys");
            m.addTrack("Puff den Magiske Drage");
            m.addTrack("Drager i Nød");
            m.addTrack("Drageboom");
            m.addTrack("Dragefestivalen");
            m.addTrack("Drageflyvningens Dårlige Dag");
            m.addTrack("Den Stakkels Drages Blues");
            m.addTrack("Drager, Drager Overalt");
            m.addTrack("Søde Drømme om Drager");
            ViewBag.Book = b;
            ViewBag.MusicCD = m;
            return View();
        }
    }
}
