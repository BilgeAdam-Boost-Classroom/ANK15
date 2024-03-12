﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolExercise;

#nullable disable

namespace SchoolExercise.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20240104073527_init1")]
    partial class init1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SchoolExercise.Danisman", b =>
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

                    b.ToTable("Danisman");
                });

            modelBuilder.Entity("SchoolExercise.Diploma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("Diplomalar");
                });

            modelBuilder.Entity("SchoolExercise.Ogrenci", b =>
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

            modelBuilder.Entity("SchoolExercise.Ogrenci", b =>
                {
                    b.HasOne("SchoolExercise.Danisman", "Danisman")
                        .WithMany("Ogrenciler")
                        .HasForeignKey("DanismanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolExercise.Diploma", "Diploma")
                        .WithOne("Ogrenci")
                        .HasForeignKey("SchoolExercise.Ogrenci", "DiplomaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Danisman");

                    b.Navigation("Diploma");
                });

            modelBuilder.Entity("SchoolExercise.Danisman", b =>
                {
                    b.Navigation("Ogrenciler");
                });

            modelBuilder.Entity("SchoolExercise.Diploma", b =>
                {
                    b.Navigation("Ogrenci")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}