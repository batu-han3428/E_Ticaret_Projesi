using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface IodemeSecenekleri
    {
        int Id { get; set; }
        string odemeSecenekleriFoto { get; set; }
        string odemeSecenekleriYazi { get; set; }
    }
}
