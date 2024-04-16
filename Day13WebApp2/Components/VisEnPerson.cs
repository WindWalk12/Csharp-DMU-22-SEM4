using Day13WebApp2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day13WebApp2.Components
{
    public class VisEnPerson : ViewComponent
    {
        public IViewComponentResult Invoke(Person p)
        {
            p.Age += 40;
            return View(p);
        }
    }
}
