using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public interface IkategoriAlanlariRepository : IBaseRepository<urunKategorileri>
    {
        int kategoriGuncelle(urunKategorileri model);
        int kategoriSil(urunKategorileri model);
    }
}
