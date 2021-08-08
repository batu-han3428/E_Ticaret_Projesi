using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface IurunKategorileriDetay
    {
        [Key]
        int urunKategorilerDetayId { get; set; }
        urunKategorileri urunKategorileri { get; set; }
        string urunKategorileriDetayLogo { get; set; }
        string urunKategorileriKategoriAciklama { get; set; }
    }
}
