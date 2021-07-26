using BL.Models;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tasarim_Bolumu.Areas.Admin.Models.DTO;

namespace Tasarim_Bolumu.Areas.Admin.Models.ViewComponents
{
    [Area("Admin"), Authorize(Roles = "Admin")]
    public class siteReklamViewComponent: ViewComponent
    {
        private readonly IsiteReklamServices siteReklamServices;

        public siteReklamViewComponent(IsiteReklamServices siteReklamServices)
        {
            this.siteReklamServices = siteReklamServices;
        }

        public IViewComponentResult Invoke()
        {
            var veri = siteReklamServices.hepsiniListele(null);
            
            return View(veri);
        }
       
    }
}
