using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public interface IbilgiServices
    {
        int guncelle(bilgi model);

        List<bilgi> hepsiniListele(Expression<Func<bilgi, bool>> filter = null);
    }
}