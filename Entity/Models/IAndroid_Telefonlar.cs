using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface IAndroid_Telefonlar
    {
        int androidTelefonlarId { get; set; }
        List<Huawei_Android_Telefonlar> huaweiAndroidTelefonlar { get; set; }
        List<Samsung_Android_Telefonlar> samsungAndroidTelefonlar { get; set; }
        List<Oppo_Android_Telefonlar> oppoAndroidTelefonlar { get; set; }
        List<Xiomi_Android_Telefonlar> xiomiAndroidTelefonlar { get; set; }
        List<Casper_Android_Telefonlar> casperAndroidTelefonlar { get; set; }

    }
}
