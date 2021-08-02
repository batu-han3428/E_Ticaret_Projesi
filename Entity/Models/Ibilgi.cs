using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface Ibilgi
    {
        int Id { get; set; }
        string bilgiIcon { get; set; }
        string bilgiBaslik { get; set; }
        string bilgiYazi { get; set; }
    }
}
