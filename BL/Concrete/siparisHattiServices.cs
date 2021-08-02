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
    public class siparisHattiServices : IsiparisHattiServices
    {
        private IsiparisHattiRepository siparisHattiRepository;
        SqlDbContext context = new SqlDbContext();
        public siparisHattiServices(IsiparisHattiRepository siparisHattiRepository)
        {
            this.siparisHattiRepository = siparisHattiRepository;
        }

        public int guncelle(siparisHatti model)
        {
            var field = context.siparisHatti.Find(model.Id);

            if(model.siparisHattiIcon != field.siparisHattiIcon && model.siparisHattiYazi != field.siparisHattiYazi && model.siparisHattiTel != field.siparisHattiTel)
            {

                siparisHattiRepository.guncelle(model);

                return 1;
            }
            else
            {
                return 0;
            }
        }

        public List<siparisHatti> hepsiniListele(Expression<Func<siparisHatti, bool>> filter = null)
        {

            return siparisHattiRepository.hepsiniListele(filter);
        }
    }
}
