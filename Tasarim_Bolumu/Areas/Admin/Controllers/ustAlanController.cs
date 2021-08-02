using BL.Models;
using Deneme.Areas.Admin.Models;
using Entity.Concrete;
using Entity.Contexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
        private IWebHostEnvironment _hostingEnvironment;
        private SqlDbContext context;
        private readonly IsiteLogoServices siteLogoServices;
        private readonly IsiparisHattiServices siparisHattiServices;
        public ustAlanController(IustAlanServices ustAlanServices, IWebHostEnvironment environment, IsiteLogoServices siteLogoServices, IsiparisHattiServices siparisHattiServices)
        {
            this.ustAlanServices = ustAlanServices;
            context = new SqlDbContext();
            _hostingEnvironment = environment;
            this.siteLogoServices = siteLogoServices;
            this.siparisHattiServices = siparisHattiServices;
        }

        [HttpPost]
        public IActionResult enUstSpanlarKayit(ustAlan mod)
        {


            //var veriler = siteReklamServices.hepsiniListele(null);

            if (mod.ustAlanIcon == null || mod.ustAlanYazi == null)
            {

                //ModelState.AddModelError("Item2.yazi", "Boş Bırakılamaz");

                return RedirectToAction("UstBolum", "Home");
            }

            var veri = ustAlanServices.guncelle(mod);

            if (veri == 0)
            {
                //ModelState.AddModelError("", "Aynı İsmi Kayıt Edemezsin");

                //return PartialView("_AnasayfaDuzenle", model);
                return RedirectToAction("UstBolum", "Home");
            }


            return RedirectToAction("UstBolum", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> logoKayit(siteLogo item, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                bool imgResult;
                string imgPath = logoFotograf.FotografYukle(files, _hostingEnvironment, out imgResult, context, item);

                if (imgResult)
                    item.siteLogoFoto = imgPath;
                else
                {
                    //ViewBag.Message = $"Resim yükleme işleminde bir hata oluştu.";
                    return RedirectToAction("UstBolum", "Home");
                }

                int result = siteLogoServices.siteLogoGuncelle(item);

                if (result == 1)
                {
                    return RedirectToAction("UstBolum", "Home");
                }
                else
                {
                    TempData["Message"] = $"Kayıt işlemi sırasında bir hata oldu. Lütfen tüm alanları kontrol edip tekrar deneyin.";
                }
            }
            else
            {
                TempData["Message"] = $"İşlem başarısız oldu. Lütfen tüm alanları kontrol ederek tekrar deneyin.";
            }
            return RedirectToAction("UstBolum", "Home");
        }

        [HttpPost]
        public IActionResult siparisHattiKayit(siparisHatti mod)
        {

            if (mod.siparisHattiIcon == null || mod.siparisHattiYazi == null || mod.siparisHattiTel == null)
            {

                return RedirectToAction("UstBolum", "Home");
            }

            var veri = siparisHattiServices.guncelle(mod);

            if (veri == 0)
            {
                
                return RedirectToAction("UstBolum", "Home");
            }


            return RedirectToAction("UstBolum", "Home");
        }
    }
}
