using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public interface IkategoriAlanlariServices
    {
        int kategoriEkle(urunKategorileri model);
        int kategoriGuncelle(urunKategorileri model);
        int kategoriSil(urunKategorileri model);
        int kategoriDetayEkle(urunKategorileriDetay model);
        int kategoriDetayGuncelle(urunKategorileriDetay model);
        int kategoriDetaySil(urunKategorileriDetay model);
        List<urunKategorileri> hepsiniListele(Expression<Func<urunKategorileri, bool>> filter = null);
        List<urunKategorileriDetay> detayHepsiniListele();
    }
}
