using Microsoft.AspNetCore.Mvc;

namespace Class_10__1_.Controllers
{
    public class WebCont : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
