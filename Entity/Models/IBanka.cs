using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
     interface IBanka
    {
         int BankaId { get; set; }
         string BankaAdi { get; set; }
         string BankaLogo { get; set; }
         List<TaksitSecenekleri> TaksitSecenekleri { get; set; }

    }
}
