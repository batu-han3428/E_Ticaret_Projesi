using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Cep_Telefonu : ICep_Telefonu
    {
        public int cepTelefonuId { get; set; }
        public long cepTelefonuEkranCozunurlugu { get; set; }
        public string cepTelefonuIsletimSistemiYazilimi { get; set; }
        public string cepTelefonuArkaKamera { get; set; }
        public int cepTelefonuDahiliHafiza { get; set; }
        public int cepTelefonuOnKameraCozunurlugu { get; set; }
        public string cepTelefonuOnKamera { get; set; }
        public string cepTelefonuEkranSekli { get; set; }
        public string cepTelefonuİslemciAilesi { get; set; }
        public int cepTelefonuRam { get; set; }
        public string cepTelefonuRenk { get; set; }
        public float cepTelefonuEkranBoyutu { get; set; }
        public int cepTelefonuStokDurumu { get; set; }
        public List<Android_Telefonlar> AndroidTelefonlar { get; set; }
        public List<IIPhone_IOS_Telefonlar> iPhoneIOSTelefonlar { get; set; }
    }
}
