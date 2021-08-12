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
    [Area("Admin"), Authorize(Roles = "Admin")]
    public class kategoriAlanlariViewComponent : ViewComponent
    {
        private readonly IkategoriAlanlariServices kategoriAlanlariServices;

        public kategoriAlanlariViewComponent(IkategoriAlanlariServices kategoriAlanlariServices)
        {
            this.kategoriAlanlariServices = kategoriAlanlariServices;
        }

        public IViewComponentResult Invoke(int ver)
        {
            
            var veri = kategoriAlanlariServices.hepsiniListele(null);

            return View(Tuple.Create<List<urunKategorileri>, int>(veri, ver));
        }
    }
}
