using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MishaShop.Controllers
{
    public class AddProductController : Controller
    {
        public AddProductController()
        {
        }

        [HttpGet]
        public IActionResult AddProductPage()
        {
            return View();
        }
    }
}

