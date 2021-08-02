using DAL.Models;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class odemeSecenekleriRepository : BaseRepository<odemeSecenekleri>, IodemeSecenekleriRepository
    {
        public int odemeSecenekleriGuncelle(odemeSecenekleri model)
        {
            try
            {
                context.odemeSecenekleri.Attach(model);
                context.Entry(model).Property(x => x.odemeSecenekleriFoto).IsModified = true;
                context.Entry(model).Property(x => x.odemeSecenekleriYazi).IsModified = true;
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
