using Class_06.Models;

using Microsoft.AspNetCore.Mvc;

namespace Class_06.Controllers
{
    public class pro : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            product prod = new product()
            {
                Title = "Lays",
                Price = 100,
            };
            return View(prod);
        }
    }
}
