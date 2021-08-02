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
    public class odemeSecenekleriServices : IodemeSecenekleriServices
    {
        private IodemeSecenekleriRepository odemeSecenekleriRepository;
        SqlDbContext context = new SqlDbContext();
        public odemeSecenekleriServices(IodemeSecenekleriRepository odemeSecenekleriRepository)
        {
            this.odemeSecenekleriRepository = odemeSecenekleriRepository;
        }

        public List<odemeSecenekleri> hepsiniListele(Expression<Func<odemeSecenekleri, bool>> filter = null)
        {

            return odemeSecenekleriRepository.hepsiniListele(filter);
        }

        public int odemeSecenekleriGuncelle(odemeSecenekleri model)
        {
            var field = context.odemeSecenekleri.Find(model.Id);

            if (model.odemeSecenekleriYazi != field.odemeSecenekleriYazi)
            {

                return odemeSecenekleriRepository.odemeSecenekleriGuncelle(model);

            }
            else
            {
                return 0;
            }
           
        }
    }
}
