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
    public class tanitimKartViewComponent:ViewComponent
    {
        private readonly ItanitimKartServices tanitimKartServices;

        public tanitimKartViewComponent(ItanitimKartServices tanitimKartServices)
        {
            this.tanitimKartServices = tanitimKartServices;
        }

        public IViewComponentResult Invoke()
        {
            var veri = tanitimKartServices.hepsiniListele(null);

            return View(veri);
        }
    }
}
