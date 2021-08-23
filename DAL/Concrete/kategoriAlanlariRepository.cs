using DAL.Models;
using Entity.Concrete;
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
                    context.Entry<urunKategorileri>(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
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

                ArrayList d = new ArrayList();

                d.Add(context.urunKategorileri.Where(x => x.urunKategorileriUstId == model.urunKategorileriId).Select(x=>x.urunKategorileriId));

                for (int i = 0; i < d.Count; i++)
                { 
                    if(context.urunKategorileri.Any(x => x.urunKategorileriUstId == d[i][i]))
                    {
                        d.Add(context.urunKategorileri.Where(x => x.urunKategorileriUstId == (int)d[i]).Select(x => x.urunKategorileriId).ToList());
                    }
                }



                return 0;        //    context.Entry<urunKategorileri>().State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                        //context.SaveChanges();
            }
            
            
        }
       
    }
}
