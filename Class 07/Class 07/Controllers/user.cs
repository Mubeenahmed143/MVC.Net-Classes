using Class_07.Models;

using Microsoft.AspNetCore.Mvc;

namespace Class_07.Controllers
{
    public class user : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Index(form from)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}
