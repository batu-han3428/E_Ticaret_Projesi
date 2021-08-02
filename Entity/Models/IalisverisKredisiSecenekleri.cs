using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface IalisverisKredisiSecenekleri
    {
        int Id { get; set; }
        string alisverisKredisiSecenekleriFoto { get; set; }
        string alisverisKredisiSecenekleriYazi { get; set; }
    }
}
