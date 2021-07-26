using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public interface IsliderServices
    {
        int fotoGuncelle(slider model);

        int tusFotoGuncelle(slider model);

        List<slider> hepsiniListele(Expression<Func<slider, bool>> filter = null);

        bool Kaydet(slider item);

    }
}
