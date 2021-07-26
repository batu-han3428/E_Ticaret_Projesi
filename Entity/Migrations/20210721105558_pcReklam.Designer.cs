﻿// <auto-generated />
using Entity.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entity.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    [Migration("20210721105558_pcReklam")]
    partial class pcReklam
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
#pragma warning restore 612, 618
        }
    }
}