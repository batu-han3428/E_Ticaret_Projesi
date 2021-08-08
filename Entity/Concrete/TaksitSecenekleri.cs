using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class TaksitSecenekleri : ITaksitSecenekleri
    {
        public int TaksitSecenekleriId { get; set; }
        public List<urunKategorileriTaksitSecenekleri> urunKategorileriTaksitSecenekleri { get; set; }
        public Banka Banka { get; set; }
        public int TaksitSecenekleriTaksitSayisi { get; set; }

    }
}
