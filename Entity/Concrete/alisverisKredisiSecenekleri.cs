using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class alisverisKredisiSecenekleri : IalisverisKredisiSecenekleri
    {
        public int Id { get; set; }
        public string alisverisKredisiSecenekleriFoto { get; set; }
        public string alisverisKredisiSecenekleriYazi { get; set; }
    }
}
