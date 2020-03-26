using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MishaShop.Models;

namespace MishaShop.Controllers
{
    public class AddProductController : Controller
    {
        private CustomerContext CustomerContext { get; set; }
        private UserManager<IdentityUser> UserManager { get; set; }

        public AddProductController(CustomerContext customerContext, UserManager<IdentityUser> userManager)
        {
            CustomerContext = customerContext;
            UserManager = userManager;
        }

        [HttpGet]
        public IActionResult AddProductPage()
        {
            var model = new FileViewModel();

            return View(model);
        }

        [HttpPost]
        [HttpGet]
        public async Task<IActionResult> AddNewProduct(FileViewModel good)
        {
            if(ModelState.IsValid)
            {
                var customer = await UserManager.FindByNameAsync(User.Identity.Name);

                var fileData = new byte[good.FileData.Length];

                using (var stream = new MemoryStream())
                {
                    await good.FileData.CopyToAsync(stream);

                    fileData = stream.ToArray();
                }

                var files = CustomerContext.Goods.ToList();

                CustomerContext.Goods.Add(new Good
                {
                        CustomerId = customer.Id.ToString(),
                        Description = good.Description,
                        FileName = Path.GetRandomFileName(),
                        Price = good.Price,
                        File = fileData,
                        FileId = (files.Count + 1).ToString(),
                        Size = good.CustomerChoise
                });

                await CustomerContext.SaveChangesAsync();

                return RedirectToAction("Index", "HomePage");
            }
            else
            {
                return View("AddProductPage");
            }
        }
    }
}

