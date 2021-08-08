using BL.Models;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tasarim_Bolumu.Areas.Admin.Models.DTO;

namespace Tasarim_Bolumu.Areas.Admin.Models.ViewComponents.footer
{
    [Area("Admin"), Authorize(Roles = "Admin")]
    public class odemeSecenekleriViewComponent : ViewComponent
    {
        private readonly IodemeSecenekleriServices odemeSecenekleriServices;

        public odemeSecenekleriViewComponent(IodemeSecenekleriServices odemeSecenekleriServices)
        {
            this.odemeSecenekleriServices = odemeSecenekleriServices;
        }

        public IViewComponentResult Invoke()
        {
            var veri = odemeSecenekleriServices.hepsiniListele(null);

            return View(veri);
        }
       
    }
}
