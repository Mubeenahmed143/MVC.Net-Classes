using Class_06.Models;

using Microsoft.AspNetCore.Mvc;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Class_06.Controllers
{
    public class fc : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
          
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(string fname, string lname, string email, int number)
        {
            form form = new form()
            {
                FirstName = fname.ToString(),
                LastName = lname.ToString(),
                Email = email.ToString(),
                Number = number,
            };
            return View(form);
       
    }
}
