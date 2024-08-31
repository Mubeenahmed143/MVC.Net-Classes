using Microsoft.AspNetCore.Mvc;

namespace Class_09.Controllers
{
	public class AdminCont : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
