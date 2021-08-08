using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface IurunKategorileri
    {
        int urunKategorileriId { get; set; }
        List<urunler> urunler { get; set; }
        string urunKategorileriKategoriAdi { get; set; }
        int urunKategorileriUstId { get; set; }
        List<urunKategorileriDetay> urunKategorileriDetay { get; set; }
        List<urunKategorileriTaksitSecenekleri> urunKategorileriTaksitSecenekleri { get; set; }
        List<marka> marka { get; set; }

        //List<ITelefon> telefon { get; set; }
        //List<Bilgisayar> bilgisayar { get; set; }
        //List<Tv_Ses_ve_Goruntu_Sistemleri> TvSesveGoruntuSistemleri { get; set; }
        //List<Beyaz_Esya_ve_Ankastre> BeyazEsyaveAnkastre { get; set; }
        //List<Elektrikli_Ev_Aletleri_ve_Yasam> ElektrikliEvAletleriveYasam { get; set; }

    }
}
