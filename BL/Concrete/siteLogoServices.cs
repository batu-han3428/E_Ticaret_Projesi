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
    public class siteLogoServices : IsiteLogoServices
    {
        private IsiteLogoRepository siteLogoRepository;
        SqlDbContext context = new SqlDbContext();
        public siteLogoServices(IsiteLogoRepository siteLogoRepository)
        {
            this.siteLogoRepository = siteLogoRepository;
        }

        public List<siteLogo> hepsiniListele(Expression<Func<siteLogo, bool>> filter = null)
        {
            return siteLogoRepository.hepsiniListele(filter);
        }

        public int siteLogoGuncelle(siteLogo model)
        {
            return siteLogoRepository.siteLogoGuncelle(model);
        }
    }
}
