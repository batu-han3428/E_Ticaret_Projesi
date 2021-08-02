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
    public class alisverisKredisiSecenekleriServices : IalisverisKredisiSecenekleriServices
    {
        private IalisverisKredisiSecenekleriRepository alisverisKredisiSecenekleriRepository;
        SqlDbContext context = new SqlDbContext();
        public alisverisKredisiSecenekleriServices(IalisverisKredisiSecenekleriRepository alisverisKredisiSecenekleriRepository)
        {
            this.alisverisKredisiSecenekleriRepository = alisverisKredisiSecenekleriRepository;
        }

        public List<alisverisKredisiSecenekleri> hepsiniListele(Expression<Func<alisverisKredisiSecenekleri, bool>> filter = null)
        {
            return alisverisKredisiSecenekleriRepository.hepsiniListele(filter);
        }

        public int alisverisKredisiSecenekleriGuncelle(alisverisKredisiSecenekleri model)
        {
            var field = context.alisverisKredisiSecenekleri.Find(model.Id);

            if (model.alisverisKredisiSecenekleriYazi != field.alisverisKredisiSecenekleriYazi)
            {

                return alisverisKredisiSecenekleriRepository.alisverisKredisiSecenekleriGuncelle(model);

            }
            else
            {
                return 0;
            }

        }
    }
}
