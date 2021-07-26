using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public interface IkategorilerServices
    {
        int guncelle(Kategoriler model);

        List<Kategoriler> hepsiniListele(Expression<Func<Kategoriler, bool>> filter = null);
    }
}