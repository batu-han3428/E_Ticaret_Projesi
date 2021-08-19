using DAL.Models;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class kategoriDetayRepository : BaseRepository<urunKategorileriDetay>, IkategoriDetayRepository
    {
        public List<urunKategorileriDetay> detaykategoriListele()
        {
            var a = context.urunKategorileriDetay.Where(x => x.urunKategorileri != null).Include(x => x.urunKategorileri).ToList();

            return a;
        }

        public int kategoriDetayEkle(urunKategorileriDetay model)
        {
           
            try
            {
                context.Entry<urunKategorileriDetay>(model).State = Microsoft.EntityFrameworkCore.EntityState.Added;
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
