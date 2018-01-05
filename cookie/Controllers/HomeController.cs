﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cookie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var cookie = new HttpCookie("li", "andy");
            cookie.Domain=".test.com";
            Response.SetCookie(cookie);
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
    }
}