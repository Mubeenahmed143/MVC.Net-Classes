using Microsoft.AspNetCore.Mvc;

namespace Class_03.Controllers
{
    public class Form : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Index(string fname, string lname)
        {
            ViewBag.Name = string.Format("Name {0} {1}" , fname, lname);
            return View();
        }
    }
}
