using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Android_Telefonlar : IAndroid_Telefonlar
    {
        public int androidTelefonlarId { get; set; }
        public List<Huawei_Android_Telefonlar> huaweiAndroidTelefonlar { get; set; }
        public List<Samsung_Android_Telefonlar> samsungAndroidTelefonlar { get; set; }
        public List<Oppo_Android_Telefonlar> oppoAndroidTelefonlar { get; set; }
        public List<Xiomi_Android_Telefonlar> xiomiAndroidTelefonlar { get; set; }
        public List<Casper_Android_Telefonlar> casperAndroidTelefonlar { get; set; }
    }
}
