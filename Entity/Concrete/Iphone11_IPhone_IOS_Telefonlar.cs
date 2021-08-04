using Entity.Models;
using System.Collections.Generic;

namespace Entity.Concrete
{
    public class Iphone11_IPhone_IOS_Telefonlar: IIphone11_IPhone_IOS_Telefonlar, ITelefonOzellikleri
    {
        public int Iphone11IPhoneIOSTelefonlarId { get; set; }
        public string TelefonOzellikleriAd { get; set; }
        public float TelefonOzellikleriAsilFiyat { get; set; }
        public float TelefonOzellikleriIndirimliFiyat { get; set; }
        public float TelefonOzellikleriEskiFiyat { get; set; }
        public int TelefonOzellikleriIndirimYuzde { get; set; }
        public string TelefonOzellikleriUrunAciklamaAd { get; set; }
        public string TelefonOzellikleriUrunAciklamaIcerik { get; set; }
        public string TelefonOzellikleriUrunAciklamaBilgi { get; set; }
        public float TelefonOzellikleriEkranBoyutu { get; set; }
        public string TelefonOzellikleriPaketeDahilKablolar { get; set; }
        public bool TelefonOzellikleriHizliBaslangicRehberi { get; set; }
        public bool TelefonOzellikleriAcSarmaAdaptor { get; set; }
        public bool TelefonOzellikleriKullanimKilavuzu { get; set; }
        public string TelefonOzellikleriEkranSekli { get; set; }
        public string TelefonOzellikleriEkranTuru { get; set; }
        public string TelefonOzellikleriEnBoyOrani { get; set; }
        public bool TelefonOzellikleriDokunmatikEkran { get; set; }
        public string TelefonOzellikleriEkranCamTuru { get; set; }
        public string TelefonOzellikleriGoruntulenenRenkSayisi { get; set; }
        public int TelefonOzellikleriPikselYogunlugu { get; set; }
        public string TelefonOzellikleriYerelAciOrani { get; set; }
        public string TelefonOzellikleriEkranCozunurlugu { get; set; }
        public int TelefonOzellikleriArkaKameraCozunurlugu { get; set; }
        public int TelefonOzellikleriOnKameraCozunurlugu { get; set; }
        public string TelefonOzellikleriIsletimSistemiYazilimi { get; set; }
        public string TelefonOzellikleriOnKameraTipi { get; set; }
        public string TelefonOzellikleriArkaKameraTipi { get; set; }
        public string TelefonOzellikleriDesteklenenVideoFormatlari { get; set; }
        public bool TelefonOzellikleriOtoFokus { get; set; }
        public int TelefonOzellikleriAgirlik { get; set; }
        public float TelefonOzellikleriYukseklik { get; set; }
        public float TelefonOzellikleriGenislik { get; set; }
        public float TelefonOzellikleriDerinlik { get; set; }
        public List<TaksitSecenekleri> taksitSecenekleri { get; set; }
    }
}