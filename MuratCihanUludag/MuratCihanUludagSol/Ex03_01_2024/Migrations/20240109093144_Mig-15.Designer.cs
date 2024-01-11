﻿// <auto-generated />
using System;
using Ex03_01_2024.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ex03_01_2024.Migrations
{
    [DbContext(typeof(OkulDbContext))]
    [Migration("20240109093144_Mig-15")]
    partial class Mig15
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DersOgrenci", b =>
                {
                    b.Property<int>("DerslerId")
                        .HasColumnType("int");

                    b.Property<int>("OgrencilerOgrenciBirincilAnahtar")
                        .HasColumnType("int");

                    b.HasKey("DerslerId", "OgrencilerOgrenciBirincilAnahtar");

                    b.HasIndex("OgrencilerOgrenciBirincilAnahtar");

                    b.ToTable("DersOgrenci");
                });

            modelBuilder.Entity("Ex03_01_2024.Models.Calisan", b =>
                {
                    b.Property<int>("CalisanPrimaryKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CalisanPrimaryKey"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SicilNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CalisanPrimaryKey");

                    b.HasIndex("SicilNo")
                        .IsUnique();

                    b.ToTable("Personnel");
                });

            modelBuilder.Entity("Ex03_01_2024.Models.Danisman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Danismanlar");
                });

            modelBuilder.Entity("Ex03_01_2024.Models.Ders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Kod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kredi")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dersler");
                });

            modelBuilder.Entity("Ex03_01_2024.Models.Diploma", b =>
                {
                    b.Property<int>("DiplomaBirincilAnahtar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiplomaBirincilAnahtar"));

                    b.Property<string>("No")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("DiplomaBirincilAnahtar");

                    b.HasIndex("No")
                        .IsUnique();

                    b.ToTable("Diplomas");
                });

            modelBuilder.Entity("Ex03_01_2024.Models.Laboratuvar", b =>
                {
                    b.Property<int>("L1")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("L2");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("L1"));

                    b.HasKey("L1");

                    b.ToTable("Laboratuvarlar");
                });

            modelBuilder.Entity("Ex03_01_2024.Models.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciBirincilAnahtar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OgrenciTekilAnahatar");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OgrenciBirincilAnahtar"));

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<int>("DanismanId")
                        .HasColumnType("int");

                    b.Property<int>("DanismanYabanciAnahtar")
                        .HasColumnType("int")
                        .HasColumnName("DanismanYabanciAnahtar");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("OgrenciAd");

                    b.Property<int>("SubeYabanciAnahtar")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OgrenciBirincilAnahtar");

                    b.HasIndex("DanismanId");

                    b.HasIndex("DanismanYabanciAnahtar")
                        .IsUnique();

                    b.HasIndex("SubeYabanciAnahtar");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Ex03_01_2024.Models.OgrenciDers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DersId")
                        .HasColumnType("int");

                    b.Property<string>("Not")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OgrenciId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DersId");

                    b.HasIndex("OgrenciId");

                    b.ToTable("OgrenciDerses");
                });

            modelBuilder.Entity("Ex03_01_2024.Models.Sube", b =>
                {
                    b.Property<int>("SubePrimaryKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SubeTekilAnahtar");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubePrimaryKey"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("SubePrimaryKey");

                    b.HasIndex("Ad")
                        .IsUnique();

                    b.ToTable("Section", (string)null);
                });

            modelBuilder.Entity("DersOgrenci", b =>
                {
                    b.HasOne("Ex03_01_2024.Models.Ders", null)
                        .WithMany()
                        .HasForeignKey("DerslerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ex03_01_2024.Models.Ogrenci", null)
                        .WithMany()
                        .HasForeignKey("OgrencilerOgrenciBirincilAnahtar")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ex03_01_2024.Models.Ogrenci", b =>
                {
                    b.HasOne("Ex03_01_2024.Models.Danisman", "Danisman")
                        .WithMany("Ogrenciler")
                        .HasForeignKey("DanismanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ex03_01_2024.Models.Diploma", "Diploma")
                        .WithOne("Ogrenci")
                        .HasForeignKey("Ex03_01_2024.Models.Ogrenci", "DanismanYabanciAnahtar")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Ex03_01_2024.Models.Sube", "Sube")
                        .WithMany("Ogrenciler")
                        .HasForeignKey("SubeYabanciAnahtar")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Danisman");

                    b.Navigation("Diploma");

                    b.Navigation("Sube");
                });

            modelBuilder.Entity("Ex03_01_2024.Models.OgrenciDers", b =>
                {
                    b.HasOne("Ex03_01_2024.Models.Ders", "Ders")
                        .WithMany("OgrenciDersler")
                        .HasForeignKey("DersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ex03_01_2024.Models.Ogrenci", "Ogrenci")
                        .WithMany("OgrenciDersler")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ders");

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("Ex03_01_2024.Models.Danisman", b =>
                {
                    b.Navigation("Ogrenciler");
                });

            modelBuilder.Entity("Ex03_01_2024.Models.Ders", b =>
                {
                    b.Navigation("OgrenciDersler");
                });

            modelBuilder.Entity("Ex03_01_2024.Models.Diploma", b =>
                {
                    b.Navigation("Ogrenci")
                        .IsRequired();
                });

            modelBuilder.Entity("Ex03_01_2024.Models.Ogrenci", b =>
                {
                    b.Navigation("OgrenciDersler");
                });

            modelBuilder.Entity("Ex03_01_2024.Models.Sube", b =>
                {
                    b.Navigation("Ogrenciler");
                });
#pragma warning restore 612, 618
        }
    }
}
