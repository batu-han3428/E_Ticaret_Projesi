using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public interface IustAlanServices
    {
        int guncelle(ustAlan model);

        List<ustAlan> hepsiniListele(Expression<Func<ustAlan, bool>> filter = null);
    }
}