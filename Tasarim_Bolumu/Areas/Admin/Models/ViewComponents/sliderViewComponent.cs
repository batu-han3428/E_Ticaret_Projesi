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
    public class sliderViewComponent: ViewComponent
    {
        private readonly IsliderServices sliderServices;

        public sliderViewComponent(IsliderServices sliderServices)
        {
            this.sliderServices = sliderServices;
        }

        public IViewComponentResult Invoke()
        {
            var veri = sliderServices.hepsiniListele(null);

            return View(veri);
        }
    }
}
