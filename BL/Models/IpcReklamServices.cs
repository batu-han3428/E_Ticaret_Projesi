using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public interface IpcReklamServices
    {
        List<pcReklam> hepsiniListele(Expression<Func<pcReklam, bool>> filter = null);
        int pcReklamFotoGuncelle(pcReklam model);
    }
}