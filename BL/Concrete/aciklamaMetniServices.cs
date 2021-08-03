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
    public class aciklamaMetniServices : IaciklamaMetniServices
    {
        private IaciklamaMetniRepository aciklamaMetniRepository;
        SqlDbContext context = new SqlDbContext();
        public aciklamaMetniServices(IaciklamaMetniRepository aciklamaMetniRepository)
        {
            this.aciklamaMetniRepository = aciklamaMetniRepository;
        }

        public int ekle(AciklamaMetni model)
        {
           
            var sayi = context.aciklamaMetni.Count();

            if (sayi < 6)
            { 
                return aciklamaMetniRepository.ekle(model);
            }
            else
            {
                return 0;
            }

        }

        public int guncelle(AciklamaMetni model)
        {
            var field = context.aciklamaMetni.Find(model.Id);
           
                if (model.aciklamaMetniBaslik != field.aciklamaMetniBaslik && model.aciklamaMetniYazi != field.aciklamaMetniYazi)
                {

                    return aciklamaMetniRepository.guncelle(model);
                }
                else
                {
                    return 0;
                }

        }

        public int sil(AciklamaMetni model)
        {

            var sayi = context.aciklamaMetni.Count();

            if (sayi > 2)
            {
                if (model.Id != 1 && model.Id != 2)
                {

                    return aciklamaMetniRepository.sil(model);
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }

        }


        public List<AciklamaMetni> hepsiniListele(Expression<Func<AciklamaMetni, bool>> filter = null)
        {

            return aciklamaMetniRepository.hepsiniListele(filter);
        }
    }
}
