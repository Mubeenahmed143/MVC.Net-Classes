using Microsoft.AspNetCore.Mvc;

namespace Class_05.Controllers
{
    public class RazorSyntax : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
