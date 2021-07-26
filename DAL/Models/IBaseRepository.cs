using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public interface IBaseRepository<T>
       where T : class, new()
    {
        void ekle(T model);
        void sil(T model);
        int guncelle(T model);
        List<T> hepsiniListele(Expression<Func<T, bool>> filter = null);
        T listele(int id);

    }
}
