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
    [Area("Admin"),Authorize(Roles ="Admin")]
    public class HomeController : Controller
    {
        private readonly IsiteReklamServices siteReklamServices;
        public HomeController(IsiteReklamServices siteReklamServices)
        {
             this.siteReklamServices = siteReklamServices;
        }

        public IActionResult Index()
        {
         
            return View();
        }

        [HttpGet]
        public PartialViewResult SayfaAyarlari()
        {
            ViewData["Baslik"] = "Sayfa Ayarları";

            return PartialView("_SayfaAyarlari");
        }

        [HttpGet]
        public PartialViewResult KontrolPaneli()
        {


            return PartialView("_KontrolPaneli");
        }

        [HttpGet]
        public PartialViewResult Anasayfa()
        {
            var veri = siteReklamServices.hepsiniListele(null);

            return PartialView("_AnasayfaDuzenle", veri);
        }

        [HttpPost]
        public IActionResult siteReklamKayit([FromForm] SiteReklam model)
        {
            if (model.icon == null || model.yazi == null)
            {
                ModelState.AddModelError("", "Alanlar Boş Bırakılamaz");

                return RedirectToAction("_AnasayfaDuzenle", "Home", new { area = "Admin" });
            }

            var veri = siteReklamServices.guncelle(model);

            if (veri == 0)
            {
                ModelState.AddModelError("", "Aynı İsmi Kayıt Edemezsin");
                return RedirectToAction("_AnasayfaDuzenle", "Home", new { area = "Admin" });
            }

            return RedirectToAction("_AnasayfaDuzenle", "Home", new { area = "Admin" });
        }

    }
}
