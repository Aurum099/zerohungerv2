using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zerohungerv2.DTO;
using zerohungerv2.EF;

namespace zerohungerv2.Controllers
{
    public class resloginController : Controller
    {
        zerohungerv2Entities2 db = new zerohungerv2Entities2();
        // GET: reslogin
        
        
        [HttpGet]
        public ActionResult reslogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult reslogin(resloginDTO l)
        {
            var user= (from u in db.RESTAURANTs
                       where u.R_ID.Equals(l.R_ID)
                       && u.R_PASS.Equals(l.R_PASS)
                       select u).SingleOrDefault();
            if(user != null ) 
            {
                Session["res_id"]= l.R_ID;
                return RedirectToAction("RestaurantDash", "restaurant"); 
            }

            else
            {
                return RedirectToAction("resLogin");
            }
        }
    }
}