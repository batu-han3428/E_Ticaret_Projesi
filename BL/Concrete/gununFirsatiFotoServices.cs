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
    public class gununFirsatiFotoServices : IgununFirsatiFotoServices
    {
        private IgununFirsatiFotoRepository gununFirsatiFotoRepository;
        SqlDbContext context = new SqlDbContext();
        public gununFirsatiFotoServices(IgununFirsatiFotoRepository gununFirsatiFotoRepository)
        {
            this.gununFirsatiFotoRepository = gununFirsatiFotoRepository;
        }

        public List<GununFirsatiFoto> hepsiniListele(Expression<Func<GununFirsatiFoto, bool>> filter = null)
        {
            return gununFirsatiFotoRepository.hepsiniListele(filter);
        }

        public int gununFirsatifotoGuncelle(GununFirsatiFoto model)
        {
            return gununFirsatiFotoRepository.gununFirsatifotoGuncelle(model);
        }
    }
}
