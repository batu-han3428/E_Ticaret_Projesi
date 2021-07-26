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
    public class pcReklamViewComponent: ViewComponent
    {
        private readonly IpcReklamServices pcReklamServices;

        public pcReklamViewComponent(IpcReklamServices pcReklamServices)
        {
            this.pcReklamServices = pcReklamServices;
        }

        public IViewComponentResult Invoke()
        {
           var veri = pcReklamServices.hepsiniListele(null);

            return View(veri);
        }
    }
}
