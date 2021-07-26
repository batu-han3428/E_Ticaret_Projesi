using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface IUstAlan
    {
        int Id { get; set; }
        string ustAlanIcon { get; set; }
        string ustAlanYazi { get; set; }
    }
}
