using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                 var a = _db.Goods.FirstOrDefault(x => x.FileId == id);
                 _db.Goods.Remove(a);
                 _db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            return RedirectToAction("CatalogPage", "Catalog");
        }
    }
}

