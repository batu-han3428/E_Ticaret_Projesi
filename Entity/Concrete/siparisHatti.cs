using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class siparisHatti : IsiparisHatti
    {
        public int Id { get; set; }
        public string siparisHattiIcon { get; set; }
        public string siparisHattiYazi { get; set; }
        public string siparisHattiTel { get; set; }
    }
}
