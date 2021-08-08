using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class UrunlerUrunOzellikleri : IUrunlerUrunOzellikleri
    {
        public int urunlerId { get; set; }
        public urunler urunler { get; set; }
        public int urunOzellikleriId { get; set; }
        public urunOzellikleri urunOzellikleri { get; set; }
    }
}
