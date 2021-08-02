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
        private readonly IsiparisHattiServices siparisHattiServices;

        public ustAlanViewComponent(IustAlanServices ustAlanServices, IsiteLogoServices siteLogoServices, IsiparisHattiServices siparisHattiServices)
        {
            this.ustAlanServices = ustAlanServices;
            this.siteLogoServices = siteLogoServices;
            this.siparisHattiServices = siparisHattiServices;
        }

        public IViewComponentResult Invoke()
        {
            var veri = ustAlanServices.hepsiniListele(null);

            var logo = siteLogoServices.hepsiniListele(null);

            var siparis = siparisHattiServices.hepsiniListele(null);


            return View(Tuple.Create<List<ustAlan>, List<siteLogo>, List<siparisHatti>>(veri, logo, siparis));
        }
    }
}
