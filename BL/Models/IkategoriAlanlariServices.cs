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
        int kategoriAlanEkle(urunKategorileri model);
        List<urunKategorileri> hepsiniListele(Expression<Func<urunKategorileri, bool>> filter = null);
    }
}
