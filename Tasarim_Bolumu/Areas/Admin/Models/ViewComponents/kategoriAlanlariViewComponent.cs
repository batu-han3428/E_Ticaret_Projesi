using BL.Models;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
        private int TempDateVeri;
        private List<urunKategorileri> veri;
        private List<urunKategorileri> ver;
        private List<urunKategorileriDetay> kategoriDetaylari;

        public kategoriAlanlariViewComponent(IkategoriAlanlariServices kategoriAlanlariServices)
        {
            this.kategoriAlanlariServices = kategoriAlanlariServices;

        }

        public IViewComponentResult Invoke()
        {
            if (TempData["altKategoriler"] != null)
            {
                ver = JsonConvert.DeserializeObject<List<urunKategorileri>>((string)TempData["altKategoriler"]);
            }
            else
            {
                ver = null;
            }
           

            veri = kategoriAlanlariServices.hepsiniListele(null);
            kategoriDetaylari = kategoriAlanlariServices.detayHepsiniListele();

            if (TempData["Veri"] == null)
            {
          
                TempDateVeri =  0;

                return View(Tuple.Create<List<urunKategorileri>, int, List<urunKategorileri>, List<urunKategorileriDetay>>(veri, TempDateVeri, ver, kategoriDetaylari));
            }
            else
            { 
                 
                TempDateVeri = (int)TempData["Veri"];
               
                return View(Tuple.Create<List<urunKategorileri>, int, List<urunKategorileri>, List<urunKategorileriDetay>>(veri, TempDateVeri, ver, kategoriDetaylari));
            }
           
        }
    }
}
