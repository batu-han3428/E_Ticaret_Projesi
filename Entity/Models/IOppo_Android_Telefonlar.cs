using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface IOppo_Android_Telefonlar
    {
        int oppoAndroidTelefonlarId { get; set; }
        List<TaksitSecenekleri> taksitSecenekleri { get; set; }

    }
}
