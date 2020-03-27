using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MishaShop.Models;

namespace MishaShop.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<IdentityUser> SignInManager { get; set; }
        private UserManager<IdentityUser> UserManager { get; set; }

        /// <summary>
        /// DI constractor
        /// </summary>
        /// <param name="signInManager"></param>
        /// <param name="userManager"></param>
        public AccountController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        /// <summary>
        /// Action to handle the login request
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel customer)
        {
            if(ModelState.IsValid)
            {
                var localUser = await UserManager.FindByEmailAsync(customer.EmailAddress);

                if(localUser != null)
                {
                    var passwordCheckResponse = await SignInManager.PasswordSignInAsync(customer.EmailAddress, customer.Password, false, true);
                    if (passwordCheckResponse.Succeeded)
                    {
                        return RedirectToAction("Index", "HomePage");
                    }
                    else
                        return View();
                }
                
                return View();
            }

            return View();
        }

        /// <summary>
        /// Action to get the login page
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public async Task <IActionResult> Logout()
        {
           await SignInManager.SignOutAsync();
            return RedirectToAction("Index","HomePage");
        }
    }
}
