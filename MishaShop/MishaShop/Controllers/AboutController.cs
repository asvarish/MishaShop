using Microsoft.AspNetCore.Mvc;

namespace MishaShop.Controllers
{
    public class AboutController : Controller
    {
        public AboutController()
        {
        }

        [HttpGet]
        public IActionResult AboutPage()
        {
            return View();
        }
    }
}
