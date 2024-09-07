using System.Net;
using System.Net.Mail;

using Microsoft.AspNetCore.Mvc;

namespace Class_10__1_.Controllers
{
    public class WebCont : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

		[HttpPost]
		public IActionResult Contact(string email , string mess)
		{

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;

            client.Credentials = new NetworkCredential("ahmedsheikhmubeen395@gmail.com", "dzvezzjuhwgoztqh");

            MailMessage mssg = new MailMessage(email, "ahmedsheikhmubeen395@gmail.com");
            mssg.Subject = "Feedback";
            mssg.Body = mess + " " + email;

            client.Send(mssg);

            ViewBag.Message = "Mail sent successfully,Role assigned";



			return View();
		}
	}
}
