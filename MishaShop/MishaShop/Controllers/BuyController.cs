using Microsoft.AspNetCore.Mvc;
using MishaShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MishaShop.Controllers 
{
    public class BuyController : Controller
    {
        private CustomerContext _db;
        public BuyController(CustomerContext db)
        {
            _db = db;
        }
        
        [HttpPost]
        [HttpGet]
        public IActionResult RegForBuy(ForBuyModel forBuyModel)
        {
            if (ModelState.IsValid && forBuyModel.City != null && forBuyModel.Street != null && forBuyModel.House != null && forBuyModel.FirstName != null && forBuyModel.LastName != null && forBuyModel.PhoneNumber != null)
            {
                _db.ForBuys.Add(forBuyModel);
                _db.SaveChanges();

                return RedirectToAction("CatalogPage", "Catalog");
            }
            else
            {
                return RedirectToAction("BuyPage", "Buy");
            }
        }
        [HttpGet]
        public IActionResult BuyPage(string id)
        {
            return View(new ForBuyModel(){GoodId = id});
        }
    }
}
