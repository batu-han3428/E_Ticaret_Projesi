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
    public class bilgiServices : IbilgiServices
    {
        private IbilgiRepository bilgiRepository;
        SqlDbContext context = new SqlDbContext();
        public bilgiServices(IbilgiRepository bilgiRepository)
        {
            this.bilgiRepository = bilgiRepository;
        }

        public int guncelle(bilgi model)
        {
            var field = context.bilgi.Find(model.Id);

            if (model.bilgiIcon == null)
            {
                if (model.bilgiBaslik != null){  
                    if (model.bilgiYazi != field.bilgiYazi && model.bilgiBaslik != field.bilgiBaslik)
                    {

                        return bilgiRepository.bilgiBaslikYaziGuncelle(model);
                    }else
                    {
                        return 0;
                    }
                }
                else
                {
                    if (model.bilgiYazi != field.bilgiYazi)
                    {

                        return bilgiRepository.bilgiBaslikYaziGuncelle(model);
                    }
                    else
                    {
                        return 0;
                    }
                } 
                
            }else if(model.bilgiYazi == null)
            {
                if (model.bilgiIcon != field.bilgiIcon)
                {

                    return bilgiRepository.bilgiIconGuncelle(model);
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }

        }

        public List<bilgi> hepsiniListele(Expression<Func<bilgi, bool>> filter = null)
        {

            return bilgiRepository.hepsiniListele(filter);
        }
    }
}
