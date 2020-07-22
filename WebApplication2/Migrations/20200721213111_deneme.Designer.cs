﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Models;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200721213111_deneme")]
    partial class deneme
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication2.Models.AylikIsTBL", b =>
                {
                    b.Property<int>("AylikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BaslamaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("IsBasligi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<int?>("KullaniciTBLKullaniciID")
                        .HasColumnType("int");

                    b.HasKey("AylikID");

                    b.HasIndex("KullaniciTBLKullaniciID");

                    b.ToTable("AylikIsTBLs");
                });

            modelBuilder.Entity("WebApplication2.Models.GunlukIsTBL", b =>
                {
                    b.Property<int>("GunlukID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BaslamaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("IsBasligi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<int?>("KullaniciTBLKullaniciID")
                        .HasColumnType("int");

                    b.HasKey("GunlukID");

                    b.HasIndex("KullaniciTBLKullaniciID");

                    b.ToTable("GunlukIsTBLs");
                });

            modelBuilder.Entity("WebApplication2.Models.HaftalikIsTBL", b =>
                {
                    b.Property<int>("HaftlikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BaslamaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("IsBasligi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<int?>("KullaniciTBLKullaniciID")
                        .HasColumnType("int");

                    b.HasKey("HaftlikID");

                    b.HasIndex("KullaniciTBLKullaniciID");

                    b.ToTable("HaftalikIsTBLs");
                });

            modelBuilder.Entity("WebApplication2.Models.KullaniciTBL", b =>
                {
                    b.Property<int>("KullaniciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KullaniciAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KullaniciID");

                    b.ToTable("KullaniciTBLs");
                });

            modelBuilder.Entity("WebApplication2.Models.NotTBL", b =>
                {
                    b.Property<int>("NotID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<DateTime>("NotAlinmaTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("NotBasligi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotIcerik")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NotID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("NotTBLs");
                });

            modelBuilder.Entity("WebApplication2.Models.AylikIsTBL", b =>
                {
                    b.HasOne("WebApplication2.Models.KullaniciTBL", "KullaniciTBL")
                        .WithMany("AylikIsTBLs")
                        .HasForeignKey("KullaniciTBLKullaniciID");
                });

            modelBuilder.Entity("WebApplication2.Models.GunlukIsTBL", b =>
                {
                    b.HasOne("WebApplication2.Models.KullaniciTBL", "KullaniciTBL")
                        .WithMany("GunlukIsTBLs")
                        .HasForeignKey("KullaniciTBLKullaniciID");
                });

            modelBuilder.Entity("WebApplication2.Models.HaftalikIsTBL", b =>
                {
                    b.HasOne("WebApplication2.Models.KullaniciTBL", "KullaniciTBL")
                        .WithMany("HaftalikIsTBLs")
                        .HasForeignKey("KullaniciTBLKullaniciID");
                });

            modelBuilder.Entity("WebApplication2.Models.NotTBL", b =>
                {
                    b.HasOne("WebApplication2.Models.KullaniciTBL", "Kullanici")
                        .WithMany("NotTBLs")
                        .HasForeignKey("KullaniciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
