using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class urunler : Iurunler
    {
        public int urunlerId { get; set; }
        public urunKategorileri urunKategorileri { get; set; }
        public marka marka { get; set; }
        public List<UrunlerUrunOzellikleri> UrunlerUrunOzellikleri { get; set; }
        public string urunlerAd { get; set; }
        public float urunlerAsilFiyat { get; set; }
        public float urunlerIndirimliFiyat { get; set; }
        public float urunlerEskiFiyat { get; set; }
        public int urunlerIndirimYuzde { get; set; }
        public float urunlerAylikTutar { get; set; }
        public string urunlerUrunAciklamaAd { get; set; }
        public string urunlerUrunAciklamaIcerik { get; set; }
        public string urunlerUrunAciklamaBilgi { get; set; }
        public int urunlerStok { get; set; }
    }
}
