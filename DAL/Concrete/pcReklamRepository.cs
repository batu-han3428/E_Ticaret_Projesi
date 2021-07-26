using DAL.Models;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class pcReklamRepository : BaseRepository<pcReklam>, IpcReklamRepository
    {
        public int pcReklamFotoGuncelle(pcReklam model)
        {
            try
            {
                context.pcReklam.Attach(model);
                context.Entry(model).Property(x => x.fotografAdiPcReklam).IsModified = true;
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
