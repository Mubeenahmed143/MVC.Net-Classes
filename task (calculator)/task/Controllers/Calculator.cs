using Microsoft.AspNetCore.Mvc;

namespace task.Controllers
{
    public class Calculator : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Index(string num1, string num2)
        {
            int number1 = Convert.ToInt32(num1);
            int number2 = Convert.ToInt32(num2);

            int sum = number1 + number2;
            ViewBag.Name = "Answer :" + sum;
            return View();
        }
    }
}
