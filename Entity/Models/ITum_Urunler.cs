using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface ITum_Urunler
    {
        int tumUrunlerId { get; set; }
        string tumUrunlerAd { get; set; }
        List<ITelefon> telefon { get; set; }
        List<Bilgisayar> bilgisayar { get; set; }
        List<Tv_Ses_ve_Goruntu_Sistemleri> TvSesveGoruntuSistemleri { get; set; }
        List<Beyaz_Esya_ve_Ankastre> BeyazEsyaveAnkastre { get; set; }
        List<Elektrikli_Ev_Aletleri_ve_Yasam> ElektrikliEvAletleriveYasam { get; set; }

    }
}
