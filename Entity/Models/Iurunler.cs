using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface Iurunler
    {
        int urunlerId { get; set; }
        urunKategorileri urunKategorileri { get; set; }
        marka marka { get; set; }
        List<UrunlerUrunOzellikleri> UrunlerUrunOzellikleri { get; set; }
        string urunlerAd { get; set; }
        float urunlerAsilFiyat { get; set; }
        float urunlerIndirimliFiyat { get; set; }
        float urunlerEskiFiyat { get; set; }
        int urunlerIndirimYuzde { get; set; }
        float urunlerAylikTutar { get; set; }
        string urunlerUrunAciklamaAd { get; set; }
        string urunlerUrunAciklamaIcerik { get; set; }
        string urunlerUrunAciklamaBilgi { get; set; }
        int urunlerStok { get; set; }

    }
}
