using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Banka : IBanka
    {
        public int BankaId { get; set; }
        public string BankaAdi { get; set; }
        public string BankaLogo { get; set; }
        public List<TaksitSecenekleri> TaksitSecenekleri { get; set; }
    }
}
