using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public interface IsiteReklamServices
    {
        int guncelle(SiteReklam model);

        List<SiteReklam> hepsiniListele(Expression<Func<SiteReklam, bool>> filter = null);
    }
}