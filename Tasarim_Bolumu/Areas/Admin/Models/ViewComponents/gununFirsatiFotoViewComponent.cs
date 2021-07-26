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
    public class gununFirsatiFotoViewComponent: ViewComponent
    { 
        private readonly IgununFirsatiFotoServices gununFirsatiFotoServices;

        public gununFirsatiFotoViewComponent(IgununFirsatiFotoServices gununFirsatiFotoServices)
        {
            this.gununFirsatiFotoServices = gununFirsatiFotoServices;
        } 
        
        public IViewComponentResult Invoke()
        {
            var veri = gununFirsatiFotoServices.hepsiniListele(null);

            return View(veri);
        }
    }
 
}
