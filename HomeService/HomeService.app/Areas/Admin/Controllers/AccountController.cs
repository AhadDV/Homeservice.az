using HomeService.app.ViewModel;
using HomeService.core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeService.app.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.roleManager = roleManager;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginvm)
        {
            if (loginvm.UserName==null||loginvm.Password==null)
            {
                ModelState.AddModelError("", "Sifre ve Parolu duzgun daxil edin");
                return View();
            }

            AppUser appUser = await _userManager.FindByNameAsync(loginvm.UserName);

            if (appUser == null)
            {
                ModelState.AddModelError("", "Sifre ve Parolu duzgun daxil edin");
                return View();
            }
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(appUser, loginvm.Password, true, true);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "duzgun username ve sifre daxil edin");
                return View();
            }

            return RedirectToAction("index", "setting");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }

     
        public async Task<IActionResult> AdminCreate()
        {
            AppUser appuser = new AppUser
            {
                UserName = "Admin",

            };

            IdentityResult result = await _userManager.CreateAsync(appuser, "Admin123@");

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View();
            }
            await _userManager.AddToRoleAsync(appuser, "Admin");

            return Ok();
        }

   
    }
}
