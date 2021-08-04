using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Telefon : ITelefon
    {
        public int telefonId { get; set; }
        public string telefonAd { get; set; }
        public List<Cep_Telefonu> cepTelefonu { get; set; }
        public List<Giyilebilir_Teknoloji> giyilebilirTeknoloji { get; set; }
        public List<Telsiz_ve_Masaustu_Telefonlar> telsizVeMasaustuTelefonlar { get; set; }
        public List<Cep_Telefonu_Aksesuarlari> cepTelefonuAksesuarlari { get; set; }
        public List<Kulakliklar> kulakliklar { get; set; }
    }
}
