using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface ITelefon
    {
         int telefonId { get; set; }
         string telefonAd { get; set; }
         List<Cep_Telefonu> cepTelefonu { get; set; }
        List<Giyilebilir_Teknoloji> giyilebilirTeknoloji { get; set; }
        List<Telsiz_ve_Masaustu_Telefonlar> telsizVeMasaustuTelefonlar { get; set; }
        List<Cep_Telefonu_Aksesuarlari> cepTelefonuAksesuarlari { get; set; }
        List<Kulakliklar> kulakliklar { get; set; }

    }
}
