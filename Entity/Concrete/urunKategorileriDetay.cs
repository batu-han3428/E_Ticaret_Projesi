using Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class urunKategorileriDetay : IurunKategorileriDetay
    {
        [Key]
        public int urunKategorilerDetayId { get; set; }
        public urunKategorileri urunKategorileri { get; set; }
        public string urunKategorileriDetayLogo { get; set; }
        public string urunKategorileriKategoriAciklama { get; set; }
    }
}
