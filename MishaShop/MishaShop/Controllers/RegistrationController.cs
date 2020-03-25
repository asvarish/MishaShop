using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MishaShop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MishaShop.Controllers
{
    public class RegistrationController : Controller
    {
        private UserManager<IdentityUser> UserManager { get; set; }
        private SignInManager<IdentityUser> SignInManager { get; set; }

        /// <summary>
        /// Di constractor
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="signInManager"></param>
        public RegistrationController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        [HttpPost]
        [HttpGet]
        public async Task<IActionResult> RegisterNewCustomer(CustomerModel customer)
        {
            if(ModelState.IsValid)
            {
                var userData = await UserManager.FindByEmailAsync(customer.Email);

                if(userData == null)
                {
                    var accountResponse = await UserManager.CreateAsync(new IdentityUser
                    {
                        Email = customer.Email,
                        UserName = customer.Email,
                    }, customer.Password);

                    if (accountResponse.Succeeded)
                    {
                        var user = await UserManager.FindByEmailAsync(customer.Email);

                        await SignInManager.SignInAsync(user, true);

                        if (accountResponse.Succeeded)
                        {
                            return RedirectToAction("Index", "HomePage");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Poshel nahui, u teba uzhe est accout");

                        return View("Registration");
                    }
                }
            }

            return View("Registration");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View("Registration");
        }
    }
}
