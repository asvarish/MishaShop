using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MishaShop.Models;

namespace MishaShop.Controllers
{
    public class CatalogController : Controller
    {
        private CustomerContext CustomerContext { get; set; }

        private object obj = new object();

        public CatalogController(CustomerContext customerContext)
        {
            CustomerContext = customerContext;
        }
        [HttpGet]
        public IActionResult CatalogPage()
        {
            var customerData = CustomerContext.Users.ToList();

            var goodsLocal = new List<Good>();

            var viewModel = new CatalogeModel
            {
                Users = customerData,
                Goods = goodsLocal,
            };

            var goods = CustomerContext.Goods.ToList();

            foreach (var item in goods)
            {
                goodsLocal.Add(item);

                var filePath = $"wwwroot/Catalog/CustomerImages/{item.FileName.Replace(".","")}.jpg";

                using (var file = System.IO.File.Create(filePath))
                {

                }

                lock(obj)
                {
                    System.IO.File.WriteAllBytes(filePath, item.File);
                }

                viewModel.FilePath = $"CustomerImages/{item.FileName.Replace(".", "")}.jpg";
            }


            return View(viewModel);
        }
    }
}
