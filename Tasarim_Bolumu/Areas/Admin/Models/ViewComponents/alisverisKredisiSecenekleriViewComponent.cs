using BL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tasarim_Bolumu.Areas.Admin.Models.ViewComponents
{
    [Area("Admin"), Authorize(Roles = "Admin")]
    public class alisverisKredisiSecenekleriViewComponent: ViewComponent
    {
        private readonly IalisverisKredisiSecenekleriServices alisverisKredisiSecenekleriServices;

        public alisverisKredisiSecenekleriViewComponent(IalisverisKredisiSecenekleriServices alisverisKredisiSecenekleriServices)
        {
            this.alisverisKredisiSecenekleriServices = alisverisKredisiSecenekleriServices;
        }

        public IViewComponentResult Invoke()
        {
            var veri = alisverisKredisiSecenekleriServices.hepsiniListele(null);

            return View(veri);
        }
    }
}
