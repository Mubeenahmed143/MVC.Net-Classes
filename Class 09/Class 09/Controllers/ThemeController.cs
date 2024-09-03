using Microsoft.AspNetCore.Mvc;

namespace Class_09.Controllers
{
	public class ThemeController : Controller
	{
		public IActionResult Index1()
		{
			return View();
		}

        public IActionResult shop()
        {
            return View();
        }
    }
}
