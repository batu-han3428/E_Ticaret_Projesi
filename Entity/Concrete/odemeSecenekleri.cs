using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class odemeSecenekleri : IodemeSecenekleri
    {
        public int Id { get; set; }
        public string odemeSecenekleriFoto { get; set; }
        public string odemeSecenekleriYazi { get; set; }
    }
}
