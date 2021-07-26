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
    public class tanitimKartServices : ItanitimKartServices
    {
        private ItanitimKartRepository tanitimKartRepository;
        SqlDbContext context = new SqlDbContext();
        public tanitimKartServices(ItanitimKartRepository tanitimKartRepository)
        {
            this.tanitimKartRepository = tanitimKartRepository;
        }

        public List<TanitimKart> hepsiniListele(Expression<Func<TanitimKart, bool>> filter = null)
        {
            return tanitimKartRepository.hepsiniListele(filter);
        }

        public int tanitimKartfotoGuncelle(TanitimKart model)
        {
            return tanitimKartRepository.tanitimKartfotoGuncelle(model);
        }
    }
}
