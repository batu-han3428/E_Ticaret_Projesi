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
    public class gununFirsatiFotoController : Controller
    {
        private IWebHostEnvironment _hostingEnvironment;
        private readonly IgununFirsatiFotoServices gununFirsatiFotoServices;
        private SqlDbContext context;
        public gununFirsatiFotoController(IWebHostEnvironment environment, IgununFirsatiFotoServices gununFirsatiFotoServices)
        {
            _hostingEnvironment = environment;
            this.gununFirsatiFotoServices = gununFirsatiFotoServices;
            context = new SqlDbContext();
        }

        [HttpPost]
        public async Task<IActionResult> gununFirsatiFotoKayit(GununFirsatiFoto item, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                bool imgResult;
                string imgPath = gununFirsatiFotograf.FotografYukle(files, _hostingEnvironment, out imgResult, context, item);

                if (imgResult)
                    item.gununFirsatiFotoAdi = imgPath;
                else
                {
                    //ViewBag.Message = $"Resim yükleme işleminde bir hata oluştu.";
                    return RedirectToAction("Anasayfa", "Home");
                }

                int result = gununFirsatiFotoServices.gununFirsatifotoGuncelle(item);

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
