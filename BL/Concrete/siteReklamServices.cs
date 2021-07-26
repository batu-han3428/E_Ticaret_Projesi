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
    public class siteReklamServices: IsiteReklamServices
    {
        private IsiteReklamRepository siteReklamRepository;
        SqlDbContext context = new SqlDbContext();
        public siteReklamServices(IsiteReklamRepository siteReklamRepository)
        {
            this.siteReklamRepository = siteReklamRepository;
        }

        public int guncelle(SiteReklam model)
        {
            var field = context.siteReklam.Find(model.Id);

            //var veri = context.siteReklam.Any(b => b.icon == field.icon);

                       
            //if (!veri)
            if(model.icon != field.icon && model.yazi != field.yazi)
            {

                siteReklamRepository.guncelle(model);

                return 1;
            }
            else
            {
                return 0;
            }
        }

        public List<SiteReklam> hepsiniListele(Expression<Func<SiteReklam, bool>> filter = null)
        {

            return siteReklamRepository.hepsiniListele(filter);
        }
    }
}
