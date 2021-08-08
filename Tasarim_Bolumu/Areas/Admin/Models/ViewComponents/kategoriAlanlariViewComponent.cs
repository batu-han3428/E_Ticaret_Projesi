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
    public class kategoriAlanlariViewComponent : ViewComponent
    {
        private readonly IkategoriAlanlariServices kategoriAlanlariServices;

        public kategoriAlanlariViewComponent(IkategoriAlanlariServices kategoriAlanlariServices)
        {
            this.kategoriAlanlariServices = kategoriAlanlariServices;
        }

        public IViewComponentResult Invoke()
        {
            var veri = kategoriAlanlariServices.hepsiniListele(null);

            return View(veri);
        }
    }
}
