﻿using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
     interface ITaksitSecenekleri
    {
         int TaksitSecenekleriId { get; set; }
         List<urunKategorileriTaksitSecenekleri> urunKategorileriTaksitSecenekleri { get; set; }
         Banka Banka { get; set; }
         int TaksitSecenekleriTaksitSayisi { get; set; }

    }
}
