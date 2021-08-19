using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public interface IkategoriDetayRepository : IBaseRepository<urunKategorileriDetay>
    {
        int kategoriDetayEkle(urunKategorileriDetay model);
        List<urunKategorileriDetay> detaykategoriListele();
    }
}
