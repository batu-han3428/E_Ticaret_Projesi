﻿// <auto-generated />
using Entity.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entity.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    partial class SqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
#pragma warning restore 612, 618
        }
    }
}
