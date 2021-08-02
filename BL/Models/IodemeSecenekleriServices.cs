using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public interface IodemeSecenekleriServices
    {
        List<odemeSecenekleri> hepsiniListele(Expression<Func<odemeSecenekleri, bool>> filter = null);
        int odemeSecenekleriGuncelle(odemeSecenekleri model);
    }
}