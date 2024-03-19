using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace zerohungerv2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult reslogin()
        {
            return RedirectToAction("reslogin", "reslogin");
        }

        public ActionResult emplogin()
        {
            return RedirectToAction("emplogin", "emplogin");
        }
        public ActionResult adminPage()
        {
            return RedirectToAction("adminLogin", "admin");
        }
    }
}