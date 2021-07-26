using BL.Models;
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

        public ustAlanViewComponent(IustAlanServices ustAlanServices)
        {
            this.ustAlanServices = ustAlanServices;
        }

        public IViewComponentResult Invoke()
        {
            var veri = ustAlanServices.hepsiniListele(null);

            return View(veri);
        }
    }
}
