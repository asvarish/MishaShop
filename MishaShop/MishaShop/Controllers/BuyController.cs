using Microsoft.AspNetCore.Mvc;
using MishaShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MishaShop.Controllers 
{
    public class BuyController : Controller
    {
        private CustomerContext _db;
        public BuyController(CustomerContext db)
        {
            _db = db;
        }
        [HttpPost]
        [HttpGet]
        public async Task<IActionResult> RegForBuy(ForBuy forBuy)
        {
            if (ModelState.IsValid && forBuy.City != null && forBuy.Street != null && forBuy.House != null && forBuy.FirstName != null && forBuy.LastName != null && forBuy.PhoneNumber != null)
            {
                CustomerContext.ForBuys.Add(new ForBuy
                {
                    CustomerId = customer.Id.ToString(),
                    Description = ForBuy.Description,
                    FileName = Path.GetRandomFileName(),
                    Price = ForBuy.Price,
                    File = fileData,
                    FileId = (files.Count + 1).ToString(),
                    Size = ForBuy.CustomerChoise
                });

                await CustomerContext.SaveChangesAsync();

                return RedirectToAction("Catalog", "CatalogPage");
            }
            else
            {
                return View("AddProductPage");
            }
        }
        [HttpGet]
        public IActionResult BuyPage()
        {
            return View();
        }
    }
}
