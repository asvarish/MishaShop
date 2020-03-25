using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MishaShop.Controllers
{
    public class CatalogController : Controller
    {
        public CatalogController()
        {
        }

        [HttpGet]
        public IActionResult CatalogPage()
        {
            return View();
        }
    }
}
