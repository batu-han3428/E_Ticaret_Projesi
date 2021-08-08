using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface Imarka
    {
        int markaId { get; set; }
        urunKategorileri urunKategorileri { get; set; }
        string markaAd { get; set; }
        List<urunler> urunler { get; set; }
    }
}
