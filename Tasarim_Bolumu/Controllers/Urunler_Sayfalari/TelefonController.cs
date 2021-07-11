using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tasarim_Bolumu.Controllers
{
    public class TelefonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetByID(int id)
        {
            return View();
        }
    }
}
