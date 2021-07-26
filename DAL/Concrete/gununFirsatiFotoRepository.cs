using DAL.Models;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class gununFirsatiFotoRepository: BaseRepository<GununFirsatiFoto>, IgununFirsatiFotoRepository
    {
        public int gununFirsatifotoGuncelle(GununFirsatiFoto model)
        {
            try
            {
                context.GununFirsatiFoto.Attach(model);
                context.Entry(model).Property(x => x.gununFirsatiFotoAdi).IsModified = true;
                context.SaveChanges();

                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
    }
}
