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
    public class sliderController : Controller
    {
        private IWebHostEnvironment _hostingEnvironment;
        private readonly IsliderServices sliderServices;
        private SqlDbContext context;
        public sliderController(IWebHostEnvironment environment, IsliderServices sliderServices)
        {
            _hostingEnvironment = environment;
            this.sliderServices = sliderServices;
            context = new SqlDbContext();
        }

        [HttpPost]
        public async Task<IActionResult> sliderFotoKayit(slider item,  List<IFormFile> files)
        {

            if (ModelState.IsValid)
            {
                bool imgResult;
                string imgPath = Fotograf.FotografYukle(files, _hostingEnvironment, out imgResult, context, item);

                if (imgResult)
                    item.fotografAdi = imgPath;
                else
                {
                    //ViewBag.Message = $"Resim yükleme işleminde bir hata oluştu.";
                    return RedirectToAction("Anasayfa", "Home");
                }

                int result = sliderServices.fotoGuncelle(item);

                if (result == 1)
                {
                    return RedirectToAction("Anasayfa", "Home");
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
            return RedirectToAction("Anasayfa", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> sliderTusFotoKayit(slider item, List<IFormFile> files)
        {

            if (ModelState.IsValid)
            {
                bool imgResult;
                string imgPath = tusFotograf.FotografYukle(files, _hostingEnvironment, out imgResult, context, item);

                if (imgResult)
                    item.fotografAdiTus = imgPath;
                else
                {
                    //ViewBag.Message = $"Resim yükleme işleminde bir hata oluştu.";
                    return RedirectToAction("Anasayfa", "Home");
                }

                int result = sliderServices.tusFotoGuncelle(item);

                if (result == 1)
                {
                    return RedirectToAction("Anasayfa", "Home");
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
            return RedirectToAction("Anasayfa", "Home");
        }
    }
}
