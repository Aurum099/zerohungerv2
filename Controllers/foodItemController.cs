using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zerohungerv2.DTO;
using zerohungerv2.EF;

namespace zerohungerv2.Controllers
{
    public class foodItemController : Controller
    {
        private zerohungerv2Entities2 db = new zerohungerv2Entities2();
        // GET: foodItem
        // GET: foodItem
        public ActionResult FoodItem()
        {
            return View();
        }

        // POST: foodItem/SubmitFoodItem
        [HttpPost]
   
        public ActionResult SubmitFoodItem(foodItemDTO foodItem)
        {
            if (ModelState.IsValid)
            {
                // Map the DTO to the entity
                var foodEntity = new FOOD_ITEM
                {
                    C_ID = foodItem.C_ID,
                    F_ID = GenerateF_Id(), // Generate F_Id randomly
                    DESCRIPTION = foodItem.DESCRIPTION,
                    QUANTITY = foodItem.QUANTITY,
                    EXPIRY = foodItem.EXPIRY
                };

                // Add the entity to the database context and save changes
                db.FOOD_ITEM.Add(foodEntity);
                db.SaveChanges();

                // Redirect to a different view or action
                return RedirectToAction("Index", "Home");
            }

            // If model state is not valid, return to the form view
            return View("FoodItem", foodItem);
        }

        // Method to generate random F_Id
        private int GenerateF_Id()
        {
            Random rnd = new Random();
            return rnd.Next(1000, 9999); // Adjust range as needed
        }
    }
}