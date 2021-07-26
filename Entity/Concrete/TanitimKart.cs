using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class TanitimKart : ITanitimKart
    {
        public int Id { get; set; }
        public string tanitimKartFotografAdi { get; set; }
    }
}
