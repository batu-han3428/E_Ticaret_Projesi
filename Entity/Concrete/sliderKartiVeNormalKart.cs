using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class sliderKartiVeNormalKart : IsliderKartiVeNormalKart
    {
        public int Id { get; set; }
        public string sliderKartiVeNormalKartFotoAdi { get; set; }
        public string icerikYazi { get; set; }
        public string puan { get; set; }
        public string puanIcon { get; set; }
        public string indirimlifiyat { get; set; }
        public string asilfiyat { get; set; }
        public string fiyatfark { get; set; }
        public string butonIcon { get; set; }
    }
}
