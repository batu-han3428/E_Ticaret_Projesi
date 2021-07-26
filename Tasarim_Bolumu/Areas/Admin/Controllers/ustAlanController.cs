﻿using BL.Models;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tasarim_Bolumu.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = "Admin")]
    public class ustAlanController : Controller
    {
        private readonly IustAlanServices ustAlanServices;

        public ustAlanController(IustAlanServices ustAlanServices)
        {
            this.ustAlanServices = ustAlanServices;
        }

        [HttpPost]
        public IActionResult ustAlanKayit(ustAlan mod)
        {


            //var veriler = siteReklamServices.hepsiniListele(null);

            if (mod.ustAlanIcon == null || mod.ustAlanYazi == null)
            {

                //ModelState.AddModelError("Item2.yazi", "Boş Bırakılamaz");

                return RedirectToAction("Anasayfa", "Home");
            }

            var veri = ustAlanServices.guncelle(mod);

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
