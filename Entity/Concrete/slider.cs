using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class slider : Islider
    {
        public int Id { get; set; }
        public string fotografAdi { get; set; }
        public string fotografAdiTus { get; set; }
    }
}
