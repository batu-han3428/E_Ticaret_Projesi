using DAL.Models;
using Entity.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class BaseRepository<T/*,TContext*/> : IBaseRepository<T>
        where T : class, new()
        //where TContext : DbContext, new()
    {
        protected SqlDbContext context;
        public BaseRepository()
        {
            context = new SqlDbContext();
        }
        public void ekle(T model)
        {
            //using (TContext context = new TContext())
            //{
            context.Set<T>().Add(model);
            context.SaveChanges();
            //}

        }

        public int guncelle(T model)
        {

            try
            {
                context.Entry<T>(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                context.SaveChanges();

                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public List<T> hepsiniListele(Expression<Func<T, bool>> filter = null)
        {
            if (filter == null)
            {
                return context.Set<T>().AsNoTracking().ToList();
            }
            else
            {
                return context.Set<T>().Where(filter).ToList();
            }
        }

        public T listele(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void sil(T model)
        {
            context.Entry<T>(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
