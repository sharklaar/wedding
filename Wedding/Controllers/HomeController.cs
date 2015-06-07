﻿using System;
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

        public ActionResult Menu()
        {
            ViewBag.Message = "Stuff you can eat";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Marc & Natalie";

            return View();
        }

        public ActionResult WeddingList()
        {
            ViewBag.Message = "Wedding List";

            return View();
        }

        public ActionResult WeddingDay()
        {
            ViewBag.Message = "Wedding Day Information";
            return View();
        }

        public ActionResult Rsvp(GuestList guestList)
        {
            if (guestList == null || guestList.Username == null)
            {
                return RedirectToAction("Index");
            }

            var helper = new DatabaseHelper();

            var guests = new GuestList();
            guests.Guests = helper.GetGuestsWithUsername(guestList.Username);
           
            return View(guests);
        }

        [HttpPost]
        public ActionResult SubmitGuests(List<Guest> guests)
        {
            if (guests == null || guests.Count == 0)
                return View();

            var helper = new DatabaseHelper();

            var guestList = new GuestList { Guests = guests };

            helper.SubmitGuestDetails(guestList);

            return View(guestList);
        }
    }
}