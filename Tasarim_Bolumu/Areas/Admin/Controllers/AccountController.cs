using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tasarim_Bolumu.Areas.Admin.Identity;
using Tasarim_Bolumu.Models.DTO;

namespace Tasarim_Bolumu.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly UserManager<CustomUser> userManager;
        private readonly SignInManager<CustomUser> signInManager;

        public AccountController(UserManager<CustomUser> userManager, SignInManager<CustomUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View(new LoginModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {

            if (!ModelState.IsValid)
            {
                
                ModelState.AddModelError("", $"{ModelState.ErrorCount} adet hata var");
                
                return View(model);
            }
            else
            {
                var user = await userManager.FindByEmailAsync(model.Email);

                if (user == null)
                {
                    ModelState.AddModelError("", "Kullanıcı Kayıtlı Değil..");
                    return View(model);
                }

                var result = await signInManager.PasswordSignInAsync(user, model.Parola, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Mail ya da Parola Yanlış..");
                return View(model);
            }

        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Login", "Account", new { area = "Admin" });
        }
    }
}
