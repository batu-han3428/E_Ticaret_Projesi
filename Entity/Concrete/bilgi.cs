using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class bilgi : Ibilgi
    {
        public int Id { get; set; }
        public string bilgiIcon { get; set; }
        public string bilgiBaslik { get; set; }
        public string bilgiYazi { get; set; }
    }
}
