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
    public class kategorilerViewComponent: ViewComponent
    {
        private readonly IkategorilerServices kategorilerServices;

        public kategorilerViewComponent(IkategorilerServices kategorilerServices)
        {
            this.kategorilerServices = kategorilerServices;
        }

        public IViewComponentResult Invoke()
        {
            var veri = kategorilerServices.hepsiniListele(null);

            return View(veri);
        }
    }
}
