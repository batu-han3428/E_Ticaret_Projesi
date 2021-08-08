using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class UrunOzellikDegerleri : IUrunOzellikDegerleri
    {
        public int UrunOzellikDegerleriId { get; set; }
        public List<urunOzellikleri> urunOzellikleri { get; set; }
        public string UrunOzellikDegerleriOzellikDeger { get; set; }
    }
}
