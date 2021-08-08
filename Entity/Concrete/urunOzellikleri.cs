using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class urunOzellikleri : IurunOzellikleri
    {
        public int urunOzellikleriId { get; set; }
        public List<UrunlerUrunOzellikleri> UrunlerUrunOzellikleri { get; set; }
        public UrunOzellikDegerleri UrunOzellikDegerleri { get; set; }
        public string urunOzellikAd { get; set; }
       
        //public float IurunOzellikleriEkranBoyutu { get; set; }
        //public string IurunOzellikleriPaketeDahilKablolar { get; set; }
        //public bool IurunOzellikleriHizliBaslangicRehberi { get; set; }
        //public bool IurunOzellikleriAcSarmaAdaptor { get; set; }
        //public bool IurunOzellikleriKullanimKilavuzu { get; set; }
        //public string IurunOzellikleriEkranSekli { get; set; }
        //public string IurunOzellikleriEkranTuru { get; set; }
        //public string IurunOzellikleriEnBoyOrani { get; set; }
        //public bool IurunOzellikleriDokunmatikEkran { get; set; }
        //public string IurunOzellikleriEkranCamTuru { get; set; }
        //public string IurunOzellikleriGoruntulenenRenkSayisi { get; set; }
        //public int IurunOzellikleriPikselYogunlugu { get; set; }
        //public string IurunOzellikleriYerelAciOrani { get; set; }
        //public string IurunOzellikleriEkranCozunurlugu { get; set; }
        //public int IurunOzellikleriArkaKameraCozunurlugu { get; set; }
        //public int IurunOzellikleriOnKameraCozunurlugu { get; set; }
        //public string IurunOzellikleriIsletimSistemiYazilimi { get; set; }
        //public string IurunOzellikleriOnKameraTipi { get; set; }
        //public string IurunOzellikleriArkaKameraTipi { get; set; }
        //public string IurunOzellikleriDesteklenenVideoFormatlari { get; set; }
        //public bool IurunOzellikleriOtoFokus { get; set; }
        //public int IurunOzellikleriAgirlik { get; set; }
        //public float IurunOzellikleriYukseklik { get; set; }
        //public float IurunOzellikleriGenislik { get; set; }
        //public float IurunOzellikleriDerinlik { get; set; }
    }
}
