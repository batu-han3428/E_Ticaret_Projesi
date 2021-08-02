using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class AciklamaMetni : IAciklamaMetni
    {
        public int Id { get; set; }
        public string aciklamaMetniBaslik { get; set; }
        public string aciklamaMetniYazi { get; set; }
    }
}
