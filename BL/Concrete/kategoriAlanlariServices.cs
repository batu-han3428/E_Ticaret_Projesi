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
        private IkategoriDetayRepository kategoriDetayRepository;
        SqlDbContext context = new SqlDbContext();
        public kategoriAlanlariServices(IkategoriAlanlariRepository kategoriAlanlariRepository, IkategoriDetayRepository kategoriDetayRepository)
        {
            this.kategoriAlanlariRepository = kategoriAlanlariRepository;
            this.kategoriDetayRepository = kategoriDetayRepository;
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

        public int kategoriDetayEkle(urunKategorileriDetay model)
        {
            var veri = context.urunKategorileriDetay.Any(a => a.urunKategorileri.urunKategorileriId == model.urunKategorileri.urunKategorileriId);

            if (veri)
            {
                return 0;
            }
            else
            {
                return kategoriDetayRepository.kategoriDetayEkle(model);
            }

        }

        public List<urunKategorileri> hepsiniListele(Expression<Func<urunKategorileri, bool>> filter = null)
        {

            return kategoriAlanlariRepository.hepsiniListele(filter);
        }
        public List<urunKategorileriDetay> detayHepsiniListele()
        {

            return kategoriDetayRepository.detaykategoriListele();
        }
    }
}
