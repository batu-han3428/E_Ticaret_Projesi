using BL.Models;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Concrete
{
    public class sliderKartiVeNormalKartServices : IsliderKartiVeNormalKartServices
    {
        public List<sliderKartiVeNormalKart> hepsiniListele(Expression<Func<sliderKartiVeNormalKart, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
