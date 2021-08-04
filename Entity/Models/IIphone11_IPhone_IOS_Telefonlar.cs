using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface IIphone11_IPhone_IOS_Telefonlar
    {
        int Iphone11IPhoneIOSTelefonlarId { get; set; }
        List<TaksitSecenekleri> taksitSecenekleri { get; set; }
    }
}
