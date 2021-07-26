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
    public class pcReklamController : Controller
    {
        private IWebHostEnvironment _hostingEnvironment;
        private readonly IpcReklamServices pcReklamServices;
        private SqlDbContext context;
        public pcReklamController(IWebHostEnvironment environment, IpcReklamServices pcReklamServices)
        {
            _hostingEnvironment = environment;
            this.pcReklamServices = pcReklamServices;
            context = new SqlDbContext();
        }

        [HttpPost]
        public async Task<IActionResult> pcReklamFotoKayit(pcReklam item, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                bool imgResult;
                string imgPath = pcReklamFotograf.FotografYukle(files, _hostingEnvironment, out imgResult, context, item);

                if (imgResult)
                    item.fotografAdiPcReklam = imgPath;
                else
                {
                    //ViewBag.Message = $"Resim yükleme işleminde bir hata oluştu.";
                    return RedirectToAction("Anasayfa", "Home");
                }

                int result = pcReklamServices.pcReklamFotoGuncelle(item);

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
