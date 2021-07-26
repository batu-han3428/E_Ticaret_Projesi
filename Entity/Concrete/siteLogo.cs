using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class siteLogo : IsiteLogo
    {
        public int Id { get; set; }
        public string siteLogoFoto { get; set; }
    }
}
