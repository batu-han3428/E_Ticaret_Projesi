using BL.Models;
using DAL.Models;
using Entity.Concrete;
using Entity.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Concrete
{
    public class ustAlanServices : IustAlanServices
    {
        private IustAlanRepository ustAlanRepository;
        SqlDbContext context = new SqlDbContext();
        public ustAlanServices(IustAlanRepository ustAlanRepository)
        {
            this.ustAlanRepository = ustAlanRepository;
        }

        public int guncelle(ustAlan model)
        {
            var field = context.ustAlan.Find(model.Id);

            //var veri = context.siteReklam.Any(b => b.icon == field.icon);

                       
            //if (!veri)
            if(model.ustAlanIcon != field.ustAlanIcon && model.ustAlanYazi != field.ustAlanYazi)
            {

                ustAlanRepository.guncelle(model);

                return 1;
            }
            else
            {
                return 0;
            }
        }

        public List<ustAlan> hepsiniListele(Expression<Func<ustAlan, bool>> filter = null)
        {

            return ustAlanRepository.hepsiniListele(filter);
        }
    }
}
