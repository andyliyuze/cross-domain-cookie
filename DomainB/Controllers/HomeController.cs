using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DomainB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
          
           var cookie = Request.Cookies.Get("li");
           if (cookie == null)
           {
               ViewBag.Message = "不存在";
           }
           else 
           {
               ViewBag.Message = cookie.Value;
           }
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