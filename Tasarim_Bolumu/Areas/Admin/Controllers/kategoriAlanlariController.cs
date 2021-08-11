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
 
    }
}
