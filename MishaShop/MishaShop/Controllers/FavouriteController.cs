using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MishaShop.Models;

namespace MishaShop.Controllers
{
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
                .ToList();
            
            return View(goods);
        }
        public ActionResult AddToFavourite(string id)
        {
            try
            {
                FavouriteGoods good = (FavouriteGoods)_db.Goods.FirstOrDefault(x => x.FileId == id);
                good.UserId = _userManager.FindByNameAsync(User.Identity.Name).Result.Id;

                _db.Favourite.Add(good);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return RedirectToPage("Favourite");
        }
        public ActionResult DeleteFromFavourite(string id)
        {
            try
            {
                FavouriteGoods good = (FavouriteGoods)_db.Goods.FirstOrDefault(x => x.FileId == id);
                _db.Favourite.Remove(good);

                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return RedirectToPage("Favourite");
        }
    }
}