using BL.Models;
using DAL.Models;
using Entity.Concrete;
using Entity.Contexts;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace BL.Concrete
{
    public class sliderServices:IsliderServices
    {
        private IsliderRepository sliderRepository;
        SqlDbContext context = new SqlDbContext();

        public sliderServices(IsliderRepository sliderRepository)
        {
            this.sliderRepository = sliderRepository;

        }

        public int fotoGuncelle(slider model)
        {

            return sliderRepository.fotoGuncelle(model);
        }
        public int tusFotoGuncelle(slider model)
        {
            
           return sliderRepository.tusFotoGuncelle(model);
        }
        public List<slider> hepsiniListele(Expression<Func<slider, bool>> filter = null)
        {

            return sliderRepository.hepsiniListele(filter);
        }

        public bool Kaydet(slider item)
        {

            return sliderRepository.Kaydet(item);

        }

    }
}
