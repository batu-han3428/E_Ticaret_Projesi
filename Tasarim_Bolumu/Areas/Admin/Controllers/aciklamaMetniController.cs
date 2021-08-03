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
    public class aciklamaMetniController : Controller
    {
        private readonly IaciklamaMetniServices aciklamaMetniServices;

        public aciklamaMetniController(IaciklamaMetniServices aciklamaMetniServices)
        {
            this.aciklamaMetniServices = aciklamaMetniServices;
        }

        [HttpPost]
        public IActionResult aciklamaMetniKayit(AciklamaMetni mod)
        {

            if (mod.aciklamaMetniBaslik == null || mod.aciklamaMetniYazi == null)
            {
                return RedirectToAction("AltBolum", "Home");
            }

            var veri = aciklamaMetniServices.ekle(mod);

            if (veri == 0)
            {      
                return RedirectToAction("AltBolum", "Home");
            }

            return RedirectToAction("AltBolum", "Home");
        }

        [HttpPost]
        public IActionResult aciklamaMetniSil(AciklamaMetni mod)
        {

            if (mod.Id == 0)
            {
                return RedirectToAction("AltBolum", "Home");
            }

            var veri = aciklamaMetniServices.sil(mod);

            if (veri == 0)
            {
                return RedirectToAction("AltBolum", "Home");
            }

            return RedirectToAction("AltBolum", "Home");
        }
    }
}
