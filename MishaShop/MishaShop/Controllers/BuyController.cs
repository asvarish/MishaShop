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
        public async Task<IActionResult> AddNewProduct(FileViewModel ForBuy)
        {
            if (ModelState.IsValid && ForBuy.Price != null && ForBuy.Description != null && ForBuy.FileData != null)
            {
                var customer = await UserManager.FindByNameAsync(User.Identity.Name);

                var fileData = new byte[ForBuy.FileData.Length];

                using (var stream = new MemoryStream())
                {
                    await ForBuy.FileData.CopyToAsync(stream);

                    fileData = stream.ToArray();
                }

                var files = CustomerContext.Goods.ToList();

                CustomerContext.Goods.Add(new Good
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

                return RedirectToAction("Index", "HomePage");
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
