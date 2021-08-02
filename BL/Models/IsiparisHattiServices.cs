using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public interface IsiparisHattiServices
    {
        int guncelle(siparisHatti model);

        List<siparisHatti> hepsiniListele(Expression<Func<siparisHatti, bool>> filter = null);
    }
}