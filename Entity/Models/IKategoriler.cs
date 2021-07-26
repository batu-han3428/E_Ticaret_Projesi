using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface IKategoriler
    {
        int Id { get; set; }
        string kategorilerTopIcon { get; set; }
        string kategorilerMobilTopIcon { get; set; }
        string kategorilerYazi { get; set; }

    }
}
