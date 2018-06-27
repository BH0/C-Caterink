using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;

namespace QuickWebProjectMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Send us a message.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string name, string email, string body)
        {
            /* 
            // may not work due to configuration + security reasons 
            MailMessage mail = new MailMessage("greengelu@gmail.com", email);
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.gmail.com";
            mail.Subject = "Email sent via Contact.cshtml web-page. from " + name;
            mail.Body = body; 
            client.Send(mail);
            */ 

            ViewBag.Message = "Thanks " + name + ", you're message has been received"; // did not change 
            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Services page";
            return View(); 
        }
    }
}