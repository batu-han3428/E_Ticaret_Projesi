using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public interface IsiteLogoServices
    {
        List<siteLogo> hepsiniListele(Expression<Func<siteLogo, bool>> filter = null);
        int siteLogoGuncelle(siteLogo model);
    }
}