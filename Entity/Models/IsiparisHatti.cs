using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface IsiparisHatti
    {
        int Id { get; set; }
        string siparisHattiIcon { get; set; }
        string siparisHattiYazi { get; set; }
        string siparisHattiTel { get; set; }
    }
}
