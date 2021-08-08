using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface IUrunlerUrunOzellikleri
    {
        int urunlerId { get; set; }
        urunler urunler { get; set; }
        int urunOzellikleriId { get; set; }
        urunOzellikleri urunOzellikleri { get; set; }
    }
}
