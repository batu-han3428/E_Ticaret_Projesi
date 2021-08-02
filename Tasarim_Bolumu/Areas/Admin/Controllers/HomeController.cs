using BL.Models;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tasarim_Bolumu.Areas.Admin.Models.DTO;

namespace Tasarim_Bolumu.Areas.Admin.Controllers
{
    [Area("Admin"),Authorize(Roles ="Admin")]
    public class HomeController : Controller
    {
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
           
            return PartialView("_AnasayfaDuzenle");
        }

        [HttpGet]
        public PartialViewResult UstBolum()
        {

            return PartialView("_UstBolumDuzenle");
        }

        [HttpGet]
        public PartialViewResult AltBolum()
        {

            return PartialView("_AltBolumDuzenle");
        }

    }
}
