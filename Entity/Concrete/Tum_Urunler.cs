using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Tum_Urunler : ITum_Urunler
    {
        public int tumUrunlerId { get; set; }
        public string tumUrunlerAd { get; set; }
        public List<ITelefon> telefon { get; set; }
        public List<Bilgisayar> bilgisayar { get; set; }
        public List<Tv_Ses_ve_Goruntu_Sistemleri> TvSesveGoruntuSistemleri { get; set; }
        public List<Beyaz_Esya_ve_Ankastre> BeyazEsyaveAnkastre { get; set; }
        public List<Elektrikli_Ev_Aletleri_ve_Yasam> ElektrikliEvAletleriveYasam { get; set; }
    }
}
