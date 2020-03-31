using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MishaShop.Models;

namespace MishaShop.Controllers
{
    public class DeleteController : Controller
    {
        public CustomerContext _db { get; set; }
        public DeleteController(CustomerContext db)
        {
            _db = db;
        }
        
        [HttpGet]
        public IActionResult Delete(string id)
        {
            try
            {
                foreach (var order in _db.ForBuys.Where(x=> x.GoodId == id))
                {
                    _db.Remove(order);
                }
                foreach (var fav in _db.Favourite.Where(x=> x.GoodId == id))
                {
                    _db.Remove(fav);
                }
                _db.Goods.Remove(_db.Goods.FirstOrDefault(x => x.FileId == id));
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            return RedirectToAction("CatalogPage", "Catalog");
        }
    }
}

