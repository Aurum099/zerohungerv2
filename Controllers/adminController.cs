using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zerohungerv2.EF;
using zerohungerv2.DTO;

namespace zerohungerv2.Controllers
{
    public class adminController : Controller
    {
        zerohungerv2Entities2 db = new zerohungerv2Entities2();
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
       
        public ActionResult AdminLogin(string username, string password)
        {
            
            if (username == "Admin" && password == "Admin123")
            {
                
                return RedirectToAction("adminDash");
            }
            else
            {
                
                ViewBag.ErrorMessage = "Invalid username or password.";
                return View();
            }
        }
        public ActionResult adminDash()
        {
            
            var collectionRequests = db.COLLECT_RQST.ToList();

            
            var distributions = db.DISTRIBUTION_RCRD.ToList();

            ViewBag.CollectionRequests = collectionRequests;
            ViewBag.Distributions = distributions;

            return View();
        }
        public ActionResult AssignEmployee(int cId)
        {
            //assign er kaj baki
            return RedirectToAction("adminDash");
        }
    }
}