using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface IurunOzellikleri
    {
        int urunOzellikleriId { get; set; }
        List<UrunlerUrunOzellikleri> UrunlerUrunOzellikleri { get; set; }
        UrunOzellikDegerleri UrunOzellikDegerleri { get; set; }
        string urunOzellikAd { get; set; }
        //float IurunOzellikleriEkranBoyutu { get; set; }
        //string IurunOzellikleriPaketeDahilKablolar { get; set; }
        //bool IurunOzellikleriHizliBaslangicRehberi { get; set; }
        //bool IurunOzellikleriAcSarmaAdaptor { get; set; }
        //bool IurunOzellikleriKullanimKilavuzu { get; set; }
        //string IurunOzellikleriEkranSekli { get; set; }
        //string IurunOzellikleriEkranTuru { get; set; }
        //string IurunOzellikleriEnBoyOrani { get; set; }
        //bool IurunOzellikleriDokunmatikEkran { get; set; }
        //string IurunOzellikleriEkranCamTuru { get; set; }
        //string IurunOzellikleriGoruntulenenRenkSayisi { get; set; }
        //int IurunOzellikleriPikselYogunlugu { get; set; }
        //string IurunOzellikleriYerelAciOrani { get; set; }
        //string IurunOzellikleriEkranCozunurlugu { get; set; }
        //int IurunOzellikleriArkaKameraCozunurlugu { get; set; }
        //int IurunOzellikleriOnKameraCozunurlugu { get; set; }
        //string IurunOzellikleriIsletimSistemiYazilimi { get; set; }
        //string IurunOzellikleriOnKameraTipi { get; set; }
        //string IurunOzellikleriArkaKameraTipi { get; set; }
        //string IurunOzellikleriDesteklenenVideoFormatlari { get; set; }
        //bool IurunOzellikleriOtoFokus { get; set; }
        //int IurunOzellikleriAgirlik { get; set; }
        //float IurunOzellikleriYukseklik { get; set; }
        //float IurunOzellikleriGenislik { get; set; }
        //float IurunOzellikleriDerinlik { get; set; }
    }
}
