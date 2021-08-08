using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface IUrunOzellikDegerleri
    {
        int UrunOzellikDegerleriId { get; set; }
        List<urunOzellikleri> urunOzellikleri { get; set; }
        string UrunOzellikDegerleriOzellikDeger { get; set; }
    }
}
