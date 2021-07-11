using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasarim_Bolumu.Areas.Admin.Identity
{
    public class CustomUser:IdentityUser
    {
        public string sifirlamaKod { get; set; }
    }
}
