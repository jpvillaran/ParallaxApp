using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ParallaxApp.Models.Security;
using ParallaxApp.ViewModels.Security;

namespace ParallaxApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ParallaxIdentityUser> userManager;
        private readonly SignInManager<ParallaxIdentityUser> loginManager;
        private readonly RoleManager<ParallaxIdentityRole> roleManager;

        public AccountController(UserManager<ParallaxIdentityUser> userManager,
            SignInManager<ParallaxIdentityUser> loginManager,
            RoleManager<ParallaxIdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.loginManager = loginManager;
            this.roleManager = roleManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel obj)
        {
            if (ModelState.IsValid)
            {
                ParallaxIdentityUser user = new ParallaxIdentityUser();
                user.UserName = obj.UserName;
                user.Email = obj.Email;
                user.FirstName = obj.FirstName;
                user.LastName = obj.LastName;

                IdentityResult result = userManager.CreateAsync
                (user, obj.Password).Result;

                if (result.Succeeded)
                {
                    if (!roleManager.RoleExistsAsync("NormalUser").Result)
                    {
                        ParallaxIdentityRole role = new ParallaxIdentityRole();
                        role.Name = "NormalUser";
                        role.Description = "Perform normal operations.";
                        IdentityResult roleResult = roleManager.
                        CreateAsync(role).Result;
                        if (!roleResult.Succeeded)
                        {
                            ModelState.AddModelError("",
                             "Error while creating role!");
                            return View(obj);
                        }
                    }

                    userManager.AddToRoleAsync(user,
                                 "NormalUser").Wait();
                    return RedirectToAction("Login", "Account");
                }
            }
            return View(obj);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel obj)
        {
            if (ModelState.IsValid)
            {
                var result = loginManager.PasswordSignInAsync
                (obj.UserName, obj.Password,
                  obj.RememberMe, false).Result;

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Invalid login!");
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LogOff()
        {
            loginManager.SignOutAsync().Wait();
            return RedirectToAction("Login", "Account");
        }
    }
}