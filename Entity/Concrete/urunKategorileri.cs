using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class urunKategorileri : IurunKategorileri
    {
        public int urunKategorileriId { get; set; }
        public List<urunler> urunler { get; set; }
        public string urunKategorileriKategoriAdi { get; set; }
        public int urunKategorileriUstId { get; set; }
        public List<urunKategorileriDetay> urunKategorileriDetay { get; set; }
        public List<urunKategorileriTaksitSecenekleri> urunKategorileriTaksitSecenekleri { get; set; }
        public List<marka> marka { get; set; }

        //List<ITelefon> telefon { get; set; }
        //List<Bilgisayar> bilgisayar { get; set; }
        //List<Tv_Ses_ve_Goruntu_Sistemleri> TvSesveGoruntuSistemleri { get; set; }
        //List<Beyaz_Esya_ve_Ankastre> BeyazEsyaveAnkastre { get; set; }
        //List<Elektrikli_Ev_Aletleri_ve_Yasam> ElektrikliEvAletleriveYasam { get; set; }
    }
}
