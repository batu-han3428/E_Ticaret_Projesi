using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class ustAlan : IUstAlan
    {
        public int Id { get; set; }
        public string ustAlanIcon { get; set; }
        public string ustAlanYazi { get; set; }
    }
}
