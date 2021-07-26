using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class GununFirsatiFoto : IGununFirsatiFoto
    {
        public int Id { get; set; }
        public string gununFirsatiFotoAdi { get; set; }
    }
}
