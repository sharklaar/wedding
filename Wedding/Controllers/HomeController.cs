using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wedding.Helpers;
using Wedding.Models;

namespace ASP.NET_MVC5_Bootstrap3_3_1_LESS.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Rsvp(Guest guest)
        {
            var helper = new DatabaseHelper();

            var guests = new GuestList();
            guests.Guests = helper.GetGuestsWithUsername(guest.Username);
           
            return View(guests);
        }

        [HttpPost]
        public ActionResult SubmitGuests(GuestList guests)
        {
            if (guests == null)
                return View();

            var helper = new DatabaseHelper();

            helper.SubmitGuestDetails(guests);

            return View();
        }
    }
}