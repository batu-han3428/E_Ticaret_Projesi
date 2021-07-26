using BL.Models;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tasarim_Bolumu.Areas.Admin.Models.DTO;

namespace Tasarim_Bolumu.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = "Admin")]
    public class SiteReklamController : Controller
    {
        private readonly IsiteReklamServices siteReklamServices;

        public SiteReklamController(IsiteReklamServices siteReklamServices)
        {
            this.siteReklamServices = siteReklamServices;
        }

        [HttpPost]
        public IActionResult siteReklamKayit(siteReklamModel mod)
        {

            
            //var veriler = siteReklamServices.hepsiniListele(null);

            if (mod.icon == null || mod.yazi == null)
            {

                //ModelState.AddModelError("Item2.yazi", "Boş Bırakılamaz");

                return RedirectToAction("Anasayfa", "Home");
            }

            SiteReklam model = new SiteReklam()
            {
                Id = mod.Id,
                icon = mod.icon,
                yazi = mod.yazi

            };

            var veri = siteReklamServices.guncelle(model);

            if (veri == 0)
            {
                //ModelState.AddModelError("", "Aynı İsmi Kayıt Edemezsin");

                //return PartialView("_AnasayfaDuzenle", model);
                return RedirectToAction("Anasayfa", "Home");
            }


            return RedirectToAction("Anasayfa", "Home");
        }
    }
}
