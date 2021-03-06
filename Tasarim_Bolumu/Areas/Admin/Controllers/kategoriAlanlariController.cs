using BL.Models;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tasarim_Bolumu.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = "Admin")]
    public class kategoriAlanlariController : Controller
    {
        private readonly IkategoriAlanlariServices kategoriAlanlariServices;

        public kategoriAlanlariController(IkategoriAlanlariServices kategoriAlanlariServices)
        {
            this.kategoriAlanlariServices = kategoriAlanlariServices;
        }

        [HttpPost]
        public IActionResult KategoriEkle(urunKategorileri mod)
        {

            if (mod.urunKategorileriKategoriAdi == null)
            {
                return RedirectToAction("Kategoriler", "Home");
            }

            var veri = kategoriAlanlariServices.kategoriEkle(mod);

            if (veri == 0)
            {
                return RedirectToAction("Kategoriler", "Home");
            }

            return RedirectToAction("Kategoriler", "Home");
        }

        [HttpPost]
        public IActionResult KategoriDetayListele(urunKategorileri mod)
        {

            if (mod.urunKategorileriId == 0)
            {
                return RedirectToAction("Kategoriler", "Home");
            }

            TempData["Veri"] = mod.urunKategorileriId;

            return RedirectToAction("Kategoriler", "Home");
        }

        [HttpPost]
        public IActionResult altKategoriDetayListele(urunKategorileri mod)
        {

            if (mod.urunKategorileriId == 0)
            {
                return RedirectToAction("Kategoriler", "Home");
            }

            TempData["altKategoriler"] = JsonConvert.SerializeObject(kategoriAlanlariServices.hepsiniListele(x => x.urunKategorileriUstId == mod.urunKategorileriId));

            return RedirectToAction("Kategoriler", "Home");
        }
    
        [HttpPost]
        public IActionResult kategoriDetayEkle(urunKategorileriDetay mod)
        {
            if (mod.urunKategorileri.urunKategorileriId == 0)
            {
                return RedirectToAction("Kategoriler", "Home");
            }

            var veri = kategoriAlanlariServices.kategoriDetayEkle(mod);

            if (veri == 0)
            {
                return RedirectToAction("Kategoriler", "Home");
            }

            return RedirectToAction("Kategoriler", "Home");
        }
        
        [HttpPost]
        public IActionResult kategoriDetayGuncelle(urunKategorileriDetay mod)
        {
            if (mod.urunKategorileri.urunKategorileriId == 0 || mod.urunKategorileriDetayLogo == null || mod.urunKategorileriKategoriAciklama == null)
            {
                return RedirectToAction("Kategoriler", "Home");
            }

            var veri = kategoriAlanlariServices.kategoriDetayGuncelle(mod);

            if (veri == 0)
            {
                return RedirectToAction("Kategoriler", "Home");
            }

            return RedirectToAction("Kategoriler", "Home");
        }

        [HttpPost]
        public IActionResult kategoriDetaySil(urunKategorileriDetay mod)
        {
            if (mod.urunKategorileri.urunKategorileriId == 0)
            {
                return RedirectToAction("Kategoriler", "Home");
            }

            var veri = kategoriAlanlariServices.kategoriDetaySil(mod);

            if (veri == 0)
            {
                return RedirectToAction("Kategoriler", "Home");
            }

            return RedirectToAction("Kategoriler", "Home");
        }

        [HttpPost]
        public IActionResult kategoriAlanGuncelle(urunKategorileri mod)
        {
            if (mod == null)
            {
                return RedirectToAction("Kategoriler", "Home");
            }

            if (mod.urunKategorileriId == 0 || mod.urunKategorileriKategoriAdi == null)
            {
                return RedirectToAction("Kategoriler", "Home");
            }

            var veri = kategoriAlanlariServices.kategoriGuncelle(mod);

            if (veri == 0)
            {
                return RedirectToAction("Kategoriler", "Home");
            }

            return RedirectToAction("Kategoriler", "Home");
        }

        [HttpPost]
        public IActionResult kategoriAlanSil(urunKategorileri mod)
        {
            if (mod.urunKategorileriId == 0)
            {
                return RedirectToAction("Kategoriler", "Home");
            }

            var veri = kategoriAlanlariServices.kategoriSil(mod);

            if (veri == 0)
            {
                return RedirectToAction("Kategoriler", "Home");
            }

            if (veri == 2)
            {
                TempData["kategoriAlanSil"] = "Bu Kategori Alanı Silinemez..";

                return RedirectToAction("Kategoriler", "Home");
            }

            return RedirectToAction("Kategoriler", "Home");
        }
    }
}
