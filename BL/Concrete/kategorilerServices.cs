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
    public class kategorilerServices : IkategorilerServices
    {
        private IkategorilerRepository kategorilerRepository;
        SqlDbContext context = new SqlDbContext();
        public kategorilerServices(IkategorilerRepository kategorilerRepository)
        {
            this.kategorilerRepository = kategorilerRepository;
        }

        public int guncelle(Kategoriler model)
        {
            var field = context.kategoriler.Find(model.Id);

            //var veri = context.siteReklam.Any(b => b.icon == field.icon);

                       
            //if (!veri)
            if(model.kategorilerTopIcon != field.kategorilerTopIcon && model.kategorilerYazi != field.kategorilerYazi && model.kategorilerMobilTopIcon != field.kategorilerMobilTopIcon)
            {

                kategorilerRepository.guncelle(model);

                return 1;
            }
            else
            {
                return 0;
            }
        }

        public List<Kategoriler> hepsiniListele(Expression<Func<Kategoriler, bool>> filter = null)
        {

            return kategorilerRepository.hepsiniListele(filter);
        }
    }
}
