using BL.Models;
using DAL.Models;
using Entity.Concrete;
using Entity.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var veri = context.siteReklam.Any(b => b.icon == model.icon);

                       
            if (!veri)
            {

                siteReklamRepository.guncelle(model);

                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
