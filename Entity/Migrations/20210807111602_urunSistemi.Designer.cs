﻿// <auto-generated />
using System;
using Entity.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entity.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    [Migration("20210807111602_urunSistemi")]
    partial class urunSistemi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.Concrete.AciklamaMetni", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("aciklamaMetniBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aciklamaMetniYazi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("aciklamaMetni");
                });

            modelBuilder.Entity("Entity.Concrete.Banka", b =>
                {
                    b.Property<int>("BankaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BankaAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankaLogo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BankaId");

                    b.ToTable("Banka");
                });

            modelBuilder.Entity("Entity.Concrete.GununFirsatiFoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("gununFirsatiFotoAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GununFirsatiFoto");
                });

            modelBuilder.Entity("Entity.Concrete.Kategoriler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("kategorilerMobilTopIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kategorilerTopIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kategorilerYazi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("kategoriler");
                });

            modelBuilder.Entity("Entity.Concrete.SiteReklam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("icon")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("yazi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Site_Reklam");
                });

            modelBuilder.Entity("Entity.Concrete.TaksitSecenekleri", b =>
                {
                    b.Property<int>("TaksitSecenekleriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BankaId")
                        .HasColumnType("int");

                    b.Property<int>("TaksitSecenekleriTaksitSayisi")
                        .HasColumnType("int");

                    b.HasKey("TaksitSecenekleriId");

                    b.HasIndex("BankaId");

                    b.ToTable("TaksitSecenekleri");
                });

            modelBuilder.Entity("Entity.Concrete.TanitimKart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tanitimKartFotografAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tanitimKart");
                });

            modelBuilder.Entity("Entity.Concrete.UrunOzellikDegerleri", b =>
                {
                    b.Property<int>("UrunOzellikDegerleriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UrunOzellikDegerleriOzellikDeger")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UrunOzellikDegerleriId");

                    b.ToTable("UrunOzellikDegerleri");
                });

            modelBuilder.Entity("Entity.Concrete.UrunlerUrunOzellikleri", b =>
                {
                    b.Property<int>("urunlerId")
                        .HasColumnType("int");

                    b.Property<int>("urunOzellikleriId")
                        .HasColumnType("int");

                    b.HasKey("urunlerId", "urunOzellikleriId");

                    b.HasIndex("urunOzellikleriId");

                    b.ToTable("UrunlerUrunOzellikleri");
                });

            modelBuilder.Entity("Entity.Concrete.alisverisKredisiSecenekleri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("alisverisKredisiSecenekleriFoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("alisverisKredisiSecenekleriYazi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("alisverisKredisiSecenekleri");
                });

            modelBuilder.Entity("Entity.Concrete.bilgi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bilgiBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bilgiIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bilgiYazi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("bilgi");
                });

            modelBuilder.Entity("Entity.Concrete.marka", b =>
                {
                    b.Property<int>("markaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("markaAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("urunKategorileriId")
                        .HasColumnType("int");

                    b.HasKey("markaId");

                    b.HasIndex("urunKategorileriId");

                    b.ToTable("marka");
                });

            modelBuilder.Entity("Entity.Concrete.odemeSecenekleri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("odemeSecenekleriFoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("odemeSecenekleriYazi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("odemeSecenekleri");
                });

            modelBuilder.Entity("Entity.Concrete.pcReklam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("fotografAdiPcReklam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("pcReklam");
                });

            modelBuilder.Entity("Entity.Concrete.siparisHatti", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("siparisHattiIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("siparisHattiTel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("siparisHattiYazi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("siparisHatti");
                });

            modelBuilder.Entity("Entity.Concrete.siteLogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("siteLogoFoto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("siteLogo");
                });

            modelBuilder.Entity("Entity.Concrete.slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("fotografAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotografAdiTus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("slider");
                });

            modelBuilder.Entity("Entity.Concrete.sliderKartiVeNormalKart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("asilfiyat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("butonIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fiyatfark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("icerikYazi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("indirimlifiyat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("puan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("puanIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sliderKartiVeNormalKartFotoAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("sliderKartiVeNormalKart");
                });

            modelBuilder.Entity("Entity.Concrete.urunKategorileri", b =>
                {
                    b.Property<int>("urunKategorileriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("urunKategorileriKategoriAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("urunKategorileriUstId")
                        .HasColumnType("int");

                    b.HasKey("urunKategorileriId");

                    b.ToTable("urunKategorileri");
                });

            modelBuilder.Entity("Entity.Concrete.urunKategorileriDetay", b =>
                {
                    b.Property<int>("urunKategorilerDetayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("urunKategorileriDetayLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("urunKategorileriId")
                        .HasColumnType("int");

                    b.Property<string>("urunKategorileriKategoriAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("urunKategorilerDetayId");

                    b.HasIndex("urunKategorileriId");

                    b.ToTable("urunKategorileriDetay");
                });

            modelBuilder.Entity("Entity.Concrete.urunKategorileriTaksitSecenekleri", b =>
                {
                    b.Property<int>("urunKategorileriId")
                        .HasColumnType("int");

                    b.Property<int>("TaksitSecenekleriId")
                        .HasColumnType("int");

                    b.HasKey("urunKategorileriId", "TaksitSecenekleriId");

                    b.HasIndex("TaksitSecenekleriId");

                    b.ToTable("urunKategorileriTaksitSecenekleri");
                });

            modelBuilder.Entity("Entity.Concrete.urunOzellikleri", b =>
                {
                    b.Property<int>("urunOzellikleriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("UrunOzellikDegerleriId")
                        .HasColumnType("int");

                    b.Property<string>("urunOzellikAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("urunOzellikleriId");

                    b.HasIndex("UrunOzellikDegerleriId");

                    b.ToTable("urunOzellikleri");
                });

            modelBuilder.Entity("Entity.Concrete.urunler", b =>
                {
                    b.Property<int>("urunlerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("markaId")
                        .HasColumnType("int");

                    b.Property<int?>("urunKategorileriId")
                        .HasColumnType("int");

                    b.Property<string>("urunlerAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("urunlerAsilFiyat")
                        .HasColumnType("real");

                    b.Property<float>("urunlerAylikTutar")
                        .HasColumnType("real");

                    b.Property<float>("urunlerEskiFiyat")
                        .HasColumnType("real");

                    b.Property<int>("urunlerIndirimYuzde")
                        .HasColumnType("int");

                    b.Property<float>("urunlerIndirimliFiyat")
                        .HasColumnType("real");

                    b.Property<int>("urunlerStok")
                        .HasColumnType("int");

                    b.Property<string>("urunlerUrunAciklamaAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urunlerUrunAciklamaBilgi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urunlerUrunAciklamaIcerik")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("urunlerId");

                    b.HasIndex("markaId");

                    b.HasIndex("urunKategorileriId");

                    b.ToTable("urunler");
                });

            modelBuilder.Entity("Entity.Concrete.ustAlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ustAlanIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ustAlanYazi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ustAlan");
                });

            modelBuilder.Entity("Entity.Concrete.TaksitSecenekleri", b =>
                {
                    b.HasOne("Entity.Concrete.Banka", "Banka")
                        .WithMany("TaksitSecenekleri")
                        .HasForeignKey("BankaId");

                    b.Navigation("Banka");
                });

            modelBuilder.Entity("Entity.Concrete.UrunlerUrunOzellikleri", b =>
                {
                    b.HasOne("Entity.Concrete.urunOzellikleri", "urunOzellikleri")
                        .WithMany("UrunlerUrunOzellikleri")
                        .HasForeignKey("urunOzellikleriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.urunler", "urunler")
                        .WithMany("UrunlerUrunOzellikleri")
                        .HasForeignKey("urunlerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("urunler");

                    b.Navigation("urunOzellikleri");
                });

            modelBuilder.Entity("Entity.Concrete.marka", b =>
                {
                    b.HasOne("Entity.Concrete.urunKategorileri", "urunKategorileri")
                        .WithMany("marka")
                        .HasForeignKey("urunKategorileriId");

                    b.Navigation("urunKategorileri");
                });

            modelBuilder.Entity("Entity.Concrete.urunKategorileriDetay", b =>
                {
                    b.HasOne("Entity.Concrete.urunKategorileri", "urunKategorileri")
                        .WithMany("urunKategorileriDetay")
                        .HasForeignKey("urunKategorileriId");

                    b.Navigation("urunKategorileri");
                });

            modelBuilder.Entity("Entity.Concrete.urunKategorileriTaksitSecenekleri", b =>
                {
                    b.HasOne("Entity.Concrete.TaksitSecenekleri", "TaksitSecenekleri")
                        .WithMany("urunKategorileriTaksitSecenekleri")
                        .HasForeignKey("TaksitSecenekleriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.urunKategorileri", "urunKategorileri")
                        .WithMany("urunKategorileriTaksitSecenekleri")
                        .HasForeignKey("urunKategorileriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaksitSecenekleri");

                    b.Navigation("urunKategorileri");
                });

            modelBuilder.Entity("Entity.Concrete.urunOzellikleri", b =>
                {
                    b.HasOne("Entity.Concrete.UrunOzellikDegerleri", "UrunOzellikDegerleri")
                        .WithMany("urunOzellikleri")
                        .HasForeignKey("UrunOzellikDegerleriId");

                    b.Navigation("UrunOzellikDegerleri");
                });

            modelBuilder.Entity("Entity.Concrete.urunler", b =>
                {
                    b.HasOne("Entity.Concrete.marka", "marka")
                        .WithMany("urunler")
                        .HasForeignKey("markaId");

                    b.HasOne("Entity.Concrete.urunKategorileri", "urunKategorileri")
                        .WithMany("urunler")
                        .HasForeignKey("urunKategorileriId");

                    b.Navigation("marka");

                    b.Navigation("urunKategorileri");
                });

            modelBuilder.Entity("Entity.Concrete.Banka", b =>
                {
                    b.Navigation("TaksitSecenekleri");
                });

            modelBuilder.Entity("Entity.Concrete.TaksitSecenekleri", b =>
                {
                    b.Navigation("urunKategorileriTaksitSecenekleri");
                });

            modelBuilder.Entity("Entity.Concrete.UrunOzellikDegerleri", b =>
                {
                    b.Navigation("urunOzellikleri");
                });

            modelBuilder.Entity("Entity.Concrete.marka", b =>
                {
                    b.Navigation("urunler");
                });

            modelBuilder.Entity("Entity.Concrete.urunKategorileri", b =>
                {
                    b.Navigation("marka");

                    b.Navigation("urunKategorileriDetay");

                    b.Navigation("urunKategorileriTaksitSecenekleri");

                    b.Navigation("urunler");
                });

            modelBuilder.Entity("Entity.Concrete.urunOzellikleri", b =>
                {
                    b.Navigation("UrunlerUrunOzellikleri");
                });

            modelBuilder.Entity("Entity.Concrete.urunler", b =>
                {
                    b.Navigation("UrunlerUrunOzellikleri");
                });
#pragma warning restore 612, 618
        }
    }
}