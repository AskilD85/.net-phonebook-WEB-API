﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.Entity;
using PhoneBook.Models;


namespace PhoneBook.Controllers
{
    public class HomeController : Controller
    {
       BookContext db = new BookContext();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View(db.Users.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}
