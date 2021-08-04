using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Phone_IOS_Telefonlar : IIPhone_IOS_Telefonlar
    {
        public int iphoneTelefonlarId { get; set; }
        public List<Iphone11_IPhone_IOS_Telefonlar> huaweiAndroidTelefonlar { get; set; }
        public List<Iphone12_IPhone_IOS_Telefonlar> samsungAndroidTelefonlar { get; set; }
        public List<IphoneSE_IPhone_IOS_Telefonlar> oppoAndroidTelefonlar { get; set; }
        public List<IphoneXR_IPhone_IOS_Telefonlar> xiomiAndroidTelefonlar { get; set; }
        public List<Iphone12ProMax_IPhone_IOS_Telefonlar> casperAndroidTelefonlar { get; set; }
    }
}
