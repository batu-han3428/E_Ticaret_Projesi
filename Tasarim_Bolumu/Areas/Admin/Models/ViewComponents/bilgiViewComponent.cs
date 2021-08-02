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
    public class bilgiViewComponent: ViewComponent
    {
        private readonly IbilgiServices bilgiServices;

        public bilgiViewComponent(IbilgiServices bilgiServices)
        {
            this.bilgiServices = bilgiServices;
        }

        public IViewComponentResult Invoke()
        {
            var veri = bilgiServices.hepsiniListele(null);

            return View(veri);
        }
    }
}
