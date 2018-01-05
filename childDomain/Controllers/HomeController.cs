using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace childDomain.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page222.";

            var cookie =  Request.Cookies.Get("li");

            if (cookie == null)
            {
                ViewBag.Message = "不存在cookie";
            }
            else 
            {
                ViewBag.Message = cookie.Value;
                cookie.Expires = DateTime.Now.AddDays(-1);
                cookie.Domain = ".test.com";
                Response.Cookies.Add(cookie);
            }

         
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}