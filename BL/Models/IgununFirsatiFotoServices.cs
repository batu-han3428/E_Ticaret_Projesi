using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public interface IgununFirsatiFotoServices
    {
        List<GununFirsatiFoto> hepsiniListele(Expression<Func<GununFirsatiFoto, bool>> filter = null);
        int gununFirsatifotoGuncelle(GununFirsatiFoto model);
    }
}
