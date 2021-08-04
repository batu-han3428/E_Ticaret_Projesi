using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface ITelefonOzellikleri
    {
        string TelefonOzellikleriAd { get; set; }
        float TelefonOzellikleriAsilFiyat { get; set; }
        float TelefonOzellikleriIndirimliFiyat { get; set; }
        float TelefonOzellikleriEskiFiyat { get; set; }
        int TelefonOzellikleriIndirimYuzde { get; set; }
        string TelefonOzellikleriUrunAciklamaAd { get; set; }
        string TelefonOzellikleriUrunAciklamaIcerik { get; set; }
        string TelefonOzellikleriUrunAciklamaBilgi { get; set; }
        float TelefonOzellikleriEkranBoyutu { get; set; }
        string TelefonOzellikleriPaketeDahilKablolar { get; set; }
        bool TelefonOzellikleriHizliBaslangicRehberi { get; set; }
        bool TelefonOzellikleriAcSarmaAdaptor { get; set; }
        bool TelefonOzellikleriKullanimKilavuzu { get; set; }
        string TelefonOzellikleriEkranSekli { get; set; }
        string TelefonOzellikleriEkranTuru { get; set; }
        string TelefonOzellikleriEnBoyOrani { get; set; }
        bool TelefonOzellikleriDokunmatikEkran { get; set; }
        string TelefonOzellikleriEkranCamTuru { get; set; }
        string TelefonOzellikleriGoruntulenenRenkSayisi { get; set; }
        int TelefonOzellikleriPikselYogunlugu { get; set; }
        string TelefonOzellikleriYerelAciOrani { get; set; }
        string TelefonOzellikleriEkranCozunurlugu { get; set; }
        int TelefonOzellikleriArkaKameraCozunurlugu { get; set; }
        int TelefonOzellikleriOnKameraCozunurlugu { get; set; }
        string TelefonOzellikleriIsletimSistemiYazilimi { get; set; }
        string TelefonOzellikleriOnKameraTipi { get; set; }
        string TelefonOzellikleriArkaKameraTipi { get; set; }
        string TelefonOzellikleriDesteklenenVideoFormatlari { get; set; }
        bool TelefonOzellikleriOtoFokus { get; set; }
        int TelefonOzellikleriAgirlik { get; set; }
        float TelefonOzellikleriYukseklik { get; set; }
        float TelefonOzellikleriGenislik { get; set; }
        float TelefonOzellikleriDerinlik { get; set; }
    }
}
