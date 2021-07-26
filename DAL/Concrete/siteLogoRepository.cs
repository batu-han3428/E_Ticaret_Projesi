﻿using DAL.Models;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class siteLogoRepository : BaseRepository<siteLogo>, IsiteLogoRepository
    {
        public int siteLogoGuncelle(siteLogo model)
        {
            try
            {
                context.siteLogo.Attach(model);
                context.Entry(model).Property(x => x.siteLogoFoto).IsModified = true;
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
