using Entity.Concrete;
using System.Collections.Generic;

namespace Entity.Models
{
    public interface IIPhone_IOS_Telefonlar
    {
        int iphoneTelefonlarId { get; set; }
        List<Iphone11_IPhone_IOS_Telefonlar> huaweiAndroidTelefonlar { get; set; }
        List<Iphone12_IPhone_IOS_Telefonlar> samsungAndroidTelefonlar { get; set; }
        List<IphoneSE_IPhone_IOS_Telefonlar> oppoAndroidTelefonlar { get; set; }
        List<IphoneXR_IPhone_IOS_Telefonlar> xiomiAndroidTelefonlar { get; set; }
        List<Iphone12ProMax_IPhone_IOS_Telefonlar> casperAndroidTelefonlar { get; set; }

    }
}