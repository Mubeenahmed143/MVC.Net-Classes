using Microsoft.AspNetCore.Mvc;

namespace Class_04.Controllers
{
    public class DetailViewData : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            ViewBag.ProductTitle = "Toys";  // ViewBag = single value
            ViewBag.ProductPrice = 500;
            ViewData["ProductTitle"] = "car toy";  // ViewData = bunch of key value
            TempData["Productqty"] = "200"; // TempData = ek controller ky dusrt controller ky view mein send kr ta hy 
            TempData.Keep("Productqty"); // keep = apny pass rakh ta hy
            return View();
        }
    }
}
