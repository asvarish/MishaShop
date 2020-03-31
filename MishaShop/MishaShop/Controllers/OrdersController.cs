using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MishaShop.Models;

namespace MishaShop.Controllers
{
    public class OrdersController : Controller
    {
        private UserManager<IdentityUser> _userManager;
        private CustomerContext _db;
        public OrdersController(UserManager<IdentityUser> userManager, CustomerContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        // GET
        public IActionResult My()
        {
            var a = _db.Goods
                .Where(x => x.CustomerId == _userManager.FindByNameAsync(User.Identity.Name).Result.Id)
                .Include(x => x.Orders)
                .ToList();
            
            
            
            return View(a);
        }
    }
}