using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class marka : Imarka
    {
        public int markaId { get; set; }
        public urunKategorileri urunKategorileri { get; set; }
        public string markaAd { get; set; }
        public List<urunler> urunler { get; set; }
    }
}
