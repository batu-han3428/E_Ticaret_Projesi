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
    public class kategoriAlanlariServices : IkategoriAlanlariServices
    {
        private IkategoriAlanlariRepository kategoriAlanlariRepository;
        SqlDbContext context = new SqlDbContext();
        public kategoriAlanlariServices(IkategoriAlanlariRepository kategoriAlanlariRepository)
        {
            this.kategoriAlanlariRepository = kategoriAlanlariRepository;
        }
        public int kategoriEkle(urunKategorileri model)
        {
            var veri = context.urunKategorileri.Any(a => a.urunKategorileriKategoriAdi == model.urunKategorileriKategoriAdi);

            if (veri)
            {
                return 0;
            }
            else
            {
                return kategoriAlanlariRepository.ekle(model);
            }
           
        }

        public List<urunKategorileri> hepsiniListele(Expression<Func<urunKategorileri, bool>> filter = null)
        {

            return kategoriAlanlariRepository.hepsiniListele(filter);
        }

    }
}
