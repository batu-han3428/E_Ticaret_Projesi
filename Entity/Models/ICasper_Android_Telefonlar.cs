using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface ICasper_Android_Telefonlar
    {
        int casperAndroidTelefonlarId { get; set; }
        List<TaksitSecenekleri> taksitSecenekleri { get; set; }
    }
}
