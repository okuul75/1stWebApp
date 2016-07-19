using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebForm.Models;

namespace WebForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Powitanie =  hour < 17 ? "Dzień dobry !" : "Dobry wieczór !";

            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                // tu ma być wysyłka zawartości guestResponse

                return View("Thanks", guestResponse);
            }
            else
            {
                // ponowne wyświetlenie formularza
                return View();
            }

        }
    }
}