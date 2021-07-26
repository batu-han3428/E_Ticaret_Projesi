using BL.Models;
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
    public class kategorilerController : Controller
    {
        private readonly IkategorilerServices kategorilerServices;

        public kategorilerController(IkategorilerServices kategorilerServices)
        {
            this.kategorilerServices = kategorilerServices;
        }

        [HttpPost]
        public IActionResult kategorilerKayit(Kategoriler mod)
        {

            //var veriler = siteReklamServices.hepsiniListele(null);

            if (mod.kategorilerTopIcon == null && mod.kategorilerMobilTopIcon == null && mod.kategorilerYazi == null)
            {
               
                //ModelState.AddModelError("Item2.yazi", "Boş Bırakılamaz");

                return RedirectToAction("Anasayfa", "Home");
            }else
            {
                var veri = kategorilerServices.guncelle(mod);

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
}
