using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public interface IbilgiRepository : IBaseRepository<bilgi>
    {
        int bilgiIconGuncelle(bilgi model);
        int bilgiBaslikYaziGuncelle(bilgi model);
    }
}
