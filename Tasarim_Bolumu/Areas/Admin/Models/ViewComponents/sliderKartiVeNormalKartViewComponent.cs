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
    public class sliderKartiVeNormalKartViewComponent: ViewComponent
    {
        //private readonly IsliderKartiVeNormalKartServices sliderKartiVeNormalKartServices;

        //public sliderKartiVeNormalKartViewComponent(IsliderKartiVeNormalKartServices sliderKartiVeNormalKartServices)
        //{
        //    this.sliderKartiVeNormalKartServices = sliderKartiVeNormalKartServices;
        //}

        public IViewComponentResult Invoke()
        {
            //var veri = sliderKartiVeNormalKartServices.hepsiniListele(null);

            return View(/*veri*/);
        }
    }
}
