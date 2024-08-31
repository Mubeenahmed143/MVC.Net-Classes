using Class_08.Models;

using Microsoft.AspNetCore.Mvc;

namespace Class_08.Controllers
{
    public class birthcont : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Bday bd)
        {
            if (ModelState.IsValid)
                return Content("welcome User you are validate");
            else 

            return View(bd);
        }
    }
}
