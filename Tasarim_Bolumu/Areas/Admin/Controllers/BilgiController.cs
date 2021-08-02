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
    public class BilgiController : Controller
    {
        private readonly IbilgiServices bilgiServices;

        public BilgiController(IbilgiServices bilgiServices)
        {
            this.bilgiServices = bilgiServices;
        }

        [HttpPost]
        public IActionResult bilgiIconKayit(bilgi mod)
        {

            if (mod.bilgiIcon == null)
            {

                return RedirectToAction("AltBolum", "Home");
            }

            var veri = bilgiServices.guncelle(mod);

            if (veri == 0)
            {
               
                return RedirectToAction("AltBolum", "Home");
            }

            return RedirectToAction("AltBolum", "Home");
        }

        [HttpPost]
        public IActionResult bilgiBaslikYaziKayit(bilgi mod)
        {

            if (mod.bilgiYazi == null)
            {

                return RedirectToAction("AltBolum", "Home");
            }

            var veri = bilgiServices.guncelle(mod);

            if (veri == 0)
            {

                return RedirectToAction("AltBolum", "Home");
            }

            return RedirectToAction("AltBolum", "Home");
        }

    }
}
