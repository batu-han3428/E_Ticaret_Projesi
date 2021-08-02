using DAL.Models;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class bilgiRepository : BaseRepository<bilgi>, IbilgiRepository
    {
        public int bilgiIconGuncelle(bilgi model)
        {
            try
            {
                context.bilgi.Attach(model);
                context.Entry(model).Property(x => x.bilgiIcon).IsModified = true;
                context.SaveChanges();

                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
        
        public int bilgiBaslikYaziGuncelle(bilgi model)
        {
            try
            {
                context.bilgi.Attach(model);
                context.Entry(model).Property(x => x.bilgiBaslik).IsModified = true;
                context.Entry(model).Property(x => x.bilgiYazi).IsModified = true;
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
