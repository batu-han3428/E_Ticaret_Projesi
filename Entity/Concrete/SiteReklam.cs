using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class SiteReklam: ISiteReklam
    {
        public int Id { get; set; }
        public string icon { get; set; }
        public string yazi { get; set; }
    }
}
