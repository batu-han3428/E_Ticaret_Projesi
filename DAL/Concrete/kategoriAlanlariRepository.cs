using DAL.Models;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class kategoriAlanlariRepository : BaseRepository<urunKategorileri>, IkategoriAlanlariRepository
    {
        public int kategoriGuncelle(urunKategorileri model)
        {
            try
            {
                context.urunKategorileri.Attach(model);
                context.Entry(model).Property(x => x.urunKategorileriKategoriAdi).IsModified = true;
                context.SaveChanges();

                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int kategoriSil(urunKategorileri model)
        { 
            
            int sayi = context.urunKategorileri.Where(x => x.urunKategorileriUstId == model.urunKategorileriId).Count();

            if (sayi == 0)
            {
                try
                {

                    var kategori = context.urunKategorileri.Where(x => x.urunKategorileriId == model.urunKategorileriId).Include(x => x.urunKategorileriDetay).FirstOrDefault(x=>x.urunKategorileriId == model.urunKategorileriId);

                    if (kategori.urunKategorileriDetay.Count != 0)
                    {
                        var kategoriDetay = context.urunKategorileriDetay.FirstOrDefault(x => x.urunKategorileri.urunKategorileriId == kategori.urunKategorileriId);
                        context.Entry<urunKategorileriDetay>(kategoriDetay).State = Microsoft.EntityFrameworkCore.EntityState.Deleted; 
                    }
                   
                  
                    context.Entry<urunKategorileri>(kategori).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    context.SaveChanges();

                   return 1;
               
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
            else
            {

                return 2;  
            }
                     
        }
       
    }
}
