using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MishaShop.Models;

namespace MishaShop.Controllers
{
    [Route("[controller]/{action}")]
    public class FavouriteController : Controller
    {
        private UserManager<IdentityUser> _userManager;
        private CustomerContext _db;
        public FavouriteController(UserManager<IdentityUser> userManager, CustomerContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public ActionResult Favourite()
        {
            List<FavouriteGoods> goods = _db.Favourite
                .Where(x => x.UserId == _userManager.FindByNameAsync(User.Identity.Name).Result.Id)
                .Include(x => x.User)
                .Include(x => x.good)
                .ToList();
            
            return View(goods);
        }
        
        
        [HttpGet]
        public ActionResult AddToFavourite(string id)
        {
            try
            {
                Good good = _db.Goods.FirstOrDefault(x => x.FileId == id);
                FavouriteGoods f = new FavouriteGoods();
                f.GoodId = good.FileId;
                f.UserId = _userManager.FindByNameAsync(User.Identity.Name).Result.Id;

                if (_db.Favourite.FirstOrDefault(x =>
                    x.GoodId == good.FileId &&
                    x.UserId == _userManager.FindByNameAsync(User.Identity.Name).Result.Id) != null)
                {
                    return RedirectToAction("Favourite");
                }
                
                _db.Favourite.Add(f);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("Favourite");
        }
        
        [HttpGet]
        public ActionResult DeleteFromFavourite(int id)
        {
            try
            {
                FavouriteGoods good = _db.Favourite.FirstOrDefault(x => x.id == id);
                _db.Favourite.Remove(good);

                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return RedirectToAction("Favourite");
        }
    }
}