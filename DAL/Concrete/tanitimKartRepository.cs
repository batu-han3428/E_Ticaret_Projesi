using DAL.Models;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class tanitimKartRepository : BaseRepository<TanitimKart>, ItanitimKartRepository
    {
        public int tanitimKartfotoGuncelle(TanitimKart model)
        {
            try
            {
                context.tanitimKart.Attach(model);
                context.Entry(model).Property(x => x.tanitimKartFotografAdi).IsModified = true;
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
