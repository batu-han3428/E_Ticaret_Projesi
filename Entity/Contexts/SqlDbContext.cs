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
        public DbSet<siteLogo> siteLogo { get; set; }
        public DbSet<siparisHatti> siparisHatti { get; set; }
        public DbSet<odemeSecenekleri> odemeSecenekleri { get; set; }
        public DbSet<alisverisKredisiSecenekleri> alisverisKredisiSecenekleri { get; set; }
        public DbSet<bilgi> bilgi { get; set; }
        public DbSet<AciklamaMetni> aciklamaMetni { get; set; }
        public DbSet<urunKategorileri> urunKategorileri { get; set; }
        public DbSet<urunOzellikleri> urunOzellikleri { get; set; }
        public DbSet<UrunOzellikDegerleri> urunOzellikDegerleri { get; set; }
        public DbSet<urunler> urunler { get; set; }
        public DbSet<urunKategorileriTaksitSecenekleri> urunKategorileriTaksitSecenekleri { get; set; }
        public DbSet<urunKategorileriDetay> urunKategorileriDetay { get; set; }
        public DbSet<TaksitSecenekleri> TaksitSecenekleri { get; set; }
        public DbSet<marka> marka { get; set; }
        public DbSet<Banka> Banka { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SiteReklam>().ToTable("Site_Reklam")
                .HasKey(s => s.Id);

            modelBuilder.Entity<SiteReklam>().Property(s => s.icon).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<SiteReklam>().Property(s => s.yazi).HasMaxLength(50).IsRequired();







            modelBuilder.Entity<urunler>()
                .HasOne<urunKategorileri>(s => s.urunKategorileri)
                .WithMany(g => g.urunler);



            modelBuilder.Entity<urunOzellikleri>()
                .HasOne<UrunOzellikDegerleri>(s => s.UrunOzellikDegerleri)
                .WithMany(g => g.urunOzellikleri);


            modelBuilder.Entity<TaksitSecenekleri>()
                .HasOne<Banka>(s => s.Banka)
                .WithMany(g => g.TaksitSecenekleri);


            modelBuilder.Entity<marka>()
                .HasOne<urunKategorileri>(s => s.urunKategorileri)
                .WithMany(g => g.marka);


            modelBuilder.Entity<urunKategorileriDetay>()
               .HasOne<urunKategorileri>(s => s.urunKategorileri)
               .WithMany(g => g.urunKategorileriDetay);


            modelBuilder.Entity<urunler>()
                .HasOne<marka>(s => s.marka)
                .WithMany(g => g.urunler);





            modelBuilder.Entity<UrunlerUrunOzellikleri>()
                .HasKey(hk => new { hk.urunlerId, hk.urunOzellikleriId });

            modelBuilder.Entity<UrunlerUrunOzellikleri>()
            .HasOne(hk => hk.urunOzellikleri)
            .WithMany(h => h.UrunlerUrunOzellikleri)
            .HasForeignKey(hk => hk.urunOzellikleriId);

            modelBuilder.Entity<UrunlerUrunOzellikleri>()
            .HasOne(hk => hk.urunler)
            .WithMany(k => k.UrunlerUrunOzellikleri)
            .HasForeignKey(hk => hk.urunlerId);





            modelBuilder.Entity<urunKategorileriTaksitSecenekleri>()
                .HasKey(hk => new { hk.urunKategorileriId, hk.TaksitSecenekleriId });

            modelBuilder.Entity<urunKategorileriTaksitSecenekleri>()
            .HasOne(hk => hk.urunKategorileri)
            .WithMany(h => h.urunKategorileriTaksitSecenekleri)
            .HasForeignKey(hk => hk.urunKategorileriId);

            modelBuilder.Entity<urunKategorileriTaksitSecenekleri>()
            .HasOne(hk => hk.TaksitSecenekleri)
            .WithMany(k => k.urunKategorileriTaksitSecenekleri)
            .HasForeignKey(hk => hk.TaksitSecenekleriId);

        }
    }
}
