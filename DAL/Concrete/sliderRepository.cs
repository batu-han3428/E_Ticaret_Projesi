using DAL.Models;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class sliderRepository : BaseRepository<slider>, IsliderRepository
    {
        public bool Kaydet(slider item)
        {

            try
            {
                context.Set<slider>().Add(item);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public int fotoGuncelle(slider model)
        {
            try
            {
                context.slider.Attach(model);
                context.Entry(model).Property(x => x.fotografAdi).IsModified = true;
                context.SaveChanges();

                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
        public int tusFotoGuncelle(slider model)
        {
            try
            {
                context.slider.Attach(model);
                context.Entry(model).Property(x => x.fotografAdiTus).IsModified = true;
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
