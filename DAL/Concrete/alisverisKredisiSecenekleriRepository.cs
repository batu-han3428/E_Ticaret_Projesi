using DAL.Models;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class alisverisKredisiSecenekleriRepository : BaseRepository<alisverisKredisiSecenekleri>, IalisverisKredisiSecenekleriRepository
    {
        public int alisverisKredisiSecenekleriGuncelle(alisverisKredisiSecenekleri model)
        {
            try
            {
                context.alisverisKredisiSecenekleri.Attach(model);
                context.Entry(model).Property(x => x.alisverisKredisiSecenekleriFoto).IsModified = true;
                context.Entry(model).Property(x => x.alisverisKredisiSecenekleriYazi).IsModified = true;
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
