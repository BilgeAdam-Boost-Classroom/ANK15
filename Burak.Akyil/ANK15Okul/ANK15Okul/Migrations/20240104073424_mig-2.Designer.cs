﻿// <auto-generated />
using System;
using ANK15Okul.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ANK15Okul.Migrations
{
    [DbContext(typeof(Ank15OkulDbContext))]
    [Migration("20240104073424_mig-2")]
    partial class mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ANK15Okul.Concrete.Danisman", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Danismanlar");
                });

            modelBuilder.Entity("ANK15Okul.Concrete.Diploma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("No")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Diplomalar");
                });

            modelBuilder.Entity("ANK15Okul.Concrete.Ogrenci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DanismanId")
                        .HasColumnType("int");

                    b.Property<int>("DiplomaId")
                        .HasColumnType("int");

                    b.Property<string>("Numara")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DanismanId");

                    b.HasIndex("DiplomaId")
                        .IsUnique();

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("ANK15Okul.Concrete.Ogrenci", b =>
                {
                    b.HasOne("ANK15Okul.Concrete.Danisman", "Danisman")
                        .WithMany("Ogrenciler")
                        .HasForeignKey("DanismanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ANK15Okul.Concrete.Diploma", "Diploma")
                        .WithOne("Ogrenci")
                        .HasForeignKey("ANK15Okul.Concrete.Ogrenci", "DiplomaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Danisman");

                    b.Navigation("Diploma");
                });

            modelBuilder.Entity("ANK15Okul.Concrete.Danisman", b =>
                {
                    b.Navigation("Ogrenciler");
                });

            modelBuilder.Entity("ANK15Okul.Concrete.Diploma", b =>
                {
                    b.Navigation("Ogrenci")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
