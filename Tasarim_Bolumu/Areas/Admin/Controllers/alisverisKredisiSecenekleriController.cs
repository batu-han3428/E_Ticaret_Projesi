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
    public class alisverisKredisiSecenekleriController : Controller
    {
        private IWebHostEnvironment _hostingEnvironment;
        private SqlDbContext context;
        private readonly IalisverisKredisiSecenekleriServices alisverisKredisiSecenekleriServices;
        public alisverisKredisiSecenekleriController(IalisverisKredisiSecenekleriServices alisverisKredisiSecenekleriServices, IWebHostEnvironment environment)
        {
            context = new SqlDbContext();
            _hostingEnvironment = environment;
            this.alisverisKredisiSecenekleriServices = alisverisKredisiSecenekleriServices;
        }

        [HttpPost]
        public async Task<IActionResult> alisverisKredisiSecenekleriKayit(alisverisKredisiSecenekleri item, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                bool imgResult;
                string imgPath = alisverisKredisiSecenekleriFotograf.FotografYukle(files, _hostingEnvironment, out imgResult, context, item);

                if (imgResult)
                    item.alisverisKredisiSecenekleriFoto = imgPath;
                else
                {

                    return RedirectToAction("AltBolum", "Home");
                }

                int result = alisverisKredisiSecenekleriServices.alisverisKredisiSecenekleriGuncelle(item);

                if (result == 1)
                {
                    return RedirectToAction("AltBolum", "Home");
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
            return RedirectToAction("AltBolum", "Home");
        }
    }
}
