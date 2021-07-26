using BL.Models;
using DAL.Models;
using Entity.Concrete;
using Entity.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Concrete
{
    public class pcReklamServices : IpcReklamServices
    {
        private IpcReklamRepository pcReklamRepository;
        SqlDbContext context = new SqlDbContext();
        public pcReklamServices(IpcReklamRepository pcReklamRepository)
        {
            this.pcReklamRepository = pcReklamRepository;
        }

        public List<pcReklam> hepsiniListele(Expression<Func<pcReklam, bool>> filter = null)
        {
            return pcReklamRepository.hepsiniListele(filter);
        }

        public int pcReklamFotoGuncelle(pcReklam model)
        {
            return pcReklamRepository.pcReklamFotoGuncelle(model);
        }
    }
}
