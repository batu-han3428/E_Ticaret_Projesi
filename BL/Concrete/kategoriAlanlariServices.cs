using BL.Models;
using DAL.Models;
using Entity.Concrete;
using Entity.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

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
        public int kategoriGuncelle(urunKategorileri model)
        {
            var veri = context.urunKategorileri.Any(a => a.urunKategorileriKategoriAdi == model.urunKategorileriKategoriAdi);
           
            if (veri)
            {
                return 0;
            }
            else
            {
                return kategoriAlanlariRepository.kategoriGuncelle(model);
            }
        }
        public int kategoriSil(urunKategorileri model)
        {
            var veri = context.urunKategorileri.Any(a => a.urunKategorileriId == model.urunKategorileriId);

            if (!veri)
            {
                return 0;
            }
            else
            {
                return kategoriAlanlariRepository.kategoriSil(model);
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
        public int kategoriDetayGuncelle(urunKategorileriDetay model)
        {
            var field = context.urunKategorileriDetay.Include(x => x.urunKategorileri).FirstOrDefault(x => x.urunKategorileri.urunKategorileriId == model.urunKategorileri.urunKategorileriId);

            if (field.urunKategorileriDetayLogo == model.urunKategorileriDetayLogo && field.urunKategorileriKategoriAciklama == model.urunKategorileriKategoriAciklama)
            {
                return 0;
            }
            else
            {
                model.urunKategorilerDetayId = field.urunKategorilerDetayId;
                return kategoriDetayRepository.guncelle(model);
            }

        }
        public int kategoriDetaySil(urunKategorileriDetay model)
        {
            var veri = context.urunKategorileriDetay.Any(a => a.urunKategorileri.urunKategorileriId == model.urunKategorileri.urunKategorileriId);

            if (veri)
            {
                var field = context.urunKategorileriDetay.Include(x => x.urunKategorileri).FirstOrDefault(x => x.urunKategorileri.urunKategorileriId == model.urunKategorileri.urunKategorileriId);

                return kategoriDetayRepository.sil(field);
            }
            else
            {
                return 0;
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
