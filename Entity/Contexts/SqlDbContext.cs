using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Contexts
{
    public class SqlDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MsSqlLocalDb;database=ETicaret;Trusted_Connection=true;");
        }

        public DbSet<SiteReklam> siteReklam { get; set; }
        public DbSet<slider> slider { get; set; }
        public DbSet<GununFirsatiFoto> GununFirsatiFoto { get; set; }
        public DbSet<sliderKartiVeNormalKart> sliderKartiVeNormalKart { get; set; }
        public DbSet<pcReklam> pcReklam { get; set; }
        public DbSet<TanitimKart> tanitimKart { get; set; }
        public DbSet<Kategoriler> kategoriler { get; set; }
        public DbSet<ustAlan> ustAlan { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SiteReklam>().ToTable("Site_Reklam")
                .HasKey(s => s.Id);

            modelBuilder.Entity<SiteReklam>().Property(s => s.icon).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<SiteReklam>().Property(s => s.yazi).HasMaxLength(50).IsRequired();

        }
    }
}
