using BL.Models;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tasarim_Bolumu.Areas.Admin.Models.ViewComponents
{
    [Area("Admin"), Authorize(Roles="Admin")]
    public class ustAlanViewComponent:ViewComponent
    {
        private readonly IustAlanServices ustAlanServices;
        private readonly IsiteLogoServices siteLogoServices;

        public ustAlanViewComponent(IustAlanServices ustAlanServices, IsiteLogoServices siteLogoServices)
        {
            this.ustAlanServices = ustAlanServices;
            this.siteLogoServices = siteLogoServices;
        }

        public IViewComponentResult Invoke()
        {
            var veri = ustAlanServices.hepsiniListele(null);

            var logo = siteLogoServices.hepsiniListele(null);

            return View(Tuple.Create<List<ustAlan>, List<siteLogo>>(veri, logo));
        }
    }
}
