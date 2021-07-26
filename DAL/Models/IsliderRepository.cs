using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public interface IsliderRepository : IBaseRepository<slider>
    {
        bool Kaydet(slider item);
        int fotoGuncelle(slider model);
        int tusFotoGuncelle(slider model);
    }
}
