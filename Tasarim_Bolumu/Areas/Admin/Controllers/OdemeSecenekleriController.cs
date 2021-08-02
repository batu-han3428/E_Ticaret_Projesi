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
    public class OdemeSecenekleriController : Controller
    {
        private IWebHostEnvironment _hostingEnvironment;
        private SqlDbContext context;
        private readonly IodemeSecenekleriServices odemeSecenekleriServices;
        public OdemeSecenekleriController(IodemeSecenekleriServices odemeSecenekleriServices, IWebHostEnvironment environment)
        {
            context = new SqlDbContext();
            _hostingEnvironment = environment;
            this.odemeSecenekleriServices = odemeSecenekleriServices;
        }

        [HttpPost]
        public async Task<IActionResult> odemeSecenekleriKayit(odemeSecenekleri item, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                bool imgResult;
                string imgPath = odemeSecenekleriFotograf.FotografYukle(files, _hostingEnvironment, out imgResult, context, item);

                if (imgResult)
                    item.odemeSecenekleriFoto = imgPath;
                else
                {

                    return RedirectToAction("AltBolum", "Home");
                }

                int result = odemeSecenekleriServices.odemeSecenekleriGuncelle(item);

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
