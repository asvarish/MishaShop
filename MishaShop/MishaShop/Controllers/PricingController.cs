using System;
using Microsoft.AspNetCore.Mvc;

namespace MishaShop.Controllers
{
    public class PricingController : Controller
    {
        /// <summary>
        /// todo - add pricing view 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetPricings()
        {
            return View();
        }
    }
}
