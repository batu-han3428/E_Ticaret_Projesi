using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public interface IaciklamaMetniServices
    {
        int guncelle(AciklamaMetni model);
        int ekle(AciklamaMetni model);
        int sil(AciklamaMetni model);
        List<AciklamaMetni> hepsiniListele(Expression<Func<AciklamaMetni, bool>> filter = null);
    }
}