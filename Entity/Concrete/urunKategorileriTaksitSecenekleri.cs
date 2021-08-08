using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class urunKategorileriTaksitSecenekleri : IurunKategorileriTaksitSecenekleri
    {
        public int urunKategorileriId { get; set; }
        public urunKategorileri urunKategorileri { get; set; }
        public int TaksitSecenekleriId { get; set; }
        public TaksitSecenekleri TaksitSecenekleri { get; set; }
    }
}
