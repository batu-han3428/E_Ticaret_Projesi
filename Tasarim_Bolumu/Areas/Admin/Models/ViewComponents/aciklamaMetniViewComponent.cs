using BL.Models;
using Entity.Concrete;
using Entity.Contexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tasarim_Bolumu.Areas.Admin.Models.ViewComponents
{
    [Area("Admin"), Authorize(Roles = "Admin")]
    public class aciklamaMetniViewComponent: ViewComponent
    {
        private readonly IaciklamaMetniServices aciklamaMetniServices;
        private SqlDbContext context;

        public aciklamaMetniViewComponent(IaciklamaMetniServices aciklamaMetniServices)
        {
            this.aciklamaMetniServices = aciklamaMetniServices;
            context = new SqlDbContext();
        }

        public IViewComponentResult Invoke()
        {
            var veri = aciklamaMetniServices.hepsiniListele(null);
            int count = context.aciklamaMetni.Count();


            return View(Tuple.Create<List<AciklamaMetni>, int>(veri, count));
        }
    }
}
