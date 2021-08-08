using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface IurunKategorileriTaksitSecenekleri
    {
         int urunKategorileriId { get; set; }
         urunKategorileri urunKategorileri { get; set; }
         int TaksitSecenekleriId { get; set; }
         TaksitSecenekleri TaksitSecenekleri { get; set; }
    }
}
