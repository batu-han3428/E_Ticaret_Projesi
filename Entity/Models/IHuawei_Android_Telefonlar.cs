using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface IHuawei_Android_Telefonlar
    {
        int huaweiAndroidTelefonlarId { get; set; }
        List<TaksitSecenekleri> taksitSecenekleri { get; set; }

    }
}
