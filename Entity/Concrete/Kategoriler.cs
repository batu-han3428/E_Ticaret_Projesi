using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Kategoriler : IKategoriler
    {
        public int Id { get; set; }
        public string kategorilerTopIcon { get; set; }
        public string kategorilerYazi { get; set; }
        public string kategorilerMobilTopIcon { get; set; }
    }
}
