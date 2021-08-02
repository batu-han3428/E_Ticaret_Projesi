using BL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tasarim_Bolumu.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = "Admin")]
    public class aciklamaMetniController : Controller
    {
        private readonly IaciklamaMetniServices aciklamaMetniServices;

        public aciklamaMetniController(IaciklamaMetniServices aciklamaMetniServices)
        {
            this.aciklamaMetniServices = aciklamaMetniServices;
        }
    }
}
