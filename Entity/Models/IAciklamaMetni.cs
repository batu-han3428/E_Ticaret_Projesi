using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface IAciklamaMetni
    {
        int Id { get; set; }
        string aciklamaMetniBaslik { get; set; }
        string aciklamaMetniYazi { get; set; }
    }
}
