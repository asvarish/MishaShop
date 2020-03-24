using System;
using Microsoft.AspNetCore.Mvc;

namespace MishaShop.Controllers
{
    public class HomePageController : Controller
    {
        public HomePageController()
        {
        }

        /// <summary>
        /// Get action to return main page
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View(); // Index ( HomePage --> Index )
        }
    }
}
