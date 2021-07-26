using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface IsliderKartiVeNormalKart
    {
        int Id { get; set; }
        string sliderKartiVeNormalKartFotoAdi { get; set; }
        string icerikYazi { get; set; }
        string puan { get; set; }
        string puanIcon { get; set; }
        string indirimlifiyat { get; set; }
        string asilfiyat { get; set; }
        string fiyatfark { get; set; }
        string butonIcon { get; set; }
    }
}
