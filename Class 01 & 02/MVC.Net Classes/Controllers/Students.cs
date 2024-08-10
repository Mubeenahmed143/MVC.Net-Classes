using Microsoft.AspNetCore.Mvc;

namespace MVC.Net_Classes.Controllers
{
    public class Students : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult About()
        {
            return View("aboutus");
        }

        public IActionResult Url()
        {
            return Redirect("https://prium.github.io/elixir/v3.0.0/");
        }
        [HttpGet]
        public IActionResult Edit()
        {
            int a = 90;
            int b = 90;
            return Content("Solve the problem");
        }

        public IActionResult Details()
        {
            int abc = 60;
            if (abc == null)
            {
                return View();
            }
            return NotFound();
        }
    }
}
