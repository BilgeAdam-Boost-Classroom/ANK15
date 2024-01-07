﻿// <auto-generated />
using ArabamDb_codeFirst;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ArabamDb_codeFirst.Migrations
{
    [DbContext(typeof(ArabamDbContext))]
    partial class ArabamDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ArabaMuhendis", b =>
                {
                    b.Property<int>("ArabalarId")
                        .HasColumnType("int");

                    b.Property<int>("MuhandislerId")
                        .HasColumnType("int");

                    b.HasKey("ArabalarId", "MuhandislerId");

                    b.HasIndex("MuhandislerId");

                    b.ToTable("ArabaMuhendis");
                });

            modelBuilder.Entity("ArabamDb_codeFirst.Araba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PlakaId")
                        .HasColumnType("int");

                    b.Property<int>("SahipId")
                        .HasColumnType("int");

                    b.Property<string>("model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("yil")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlakaId")
                        .IsUnique();

                    b.HasIndex("SahipId");

                    b.ToTable("Arabalar");
                });

            modelBuilder.Entity("ArabamDb_codeFirst.Muhendis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Muhendisler");
                });

            modelBuilder.Entity("ArabamDb_codeFirst.MuhendisAraba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArabaId")
                        .HasColumnType("int");

                    b.Property<int>("MuhendisId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArabaId");

                    b.HasIndex("MuhendisId");

                    b.ToTable("MuhendisArabalar");
                });

            modelBuilder.Entity("ArabamDb_codeFirst.Plaka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Plakalar");
                });

            modelBuilder.Entity("ArabamDb_codeFirst.Sahip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sahipler");
                });

            modelBuilder.Entity("ArabaMuhendis", b =>
                {
                    b.HasOne("ArabamDb_codeFirst.Araba", null)
                        .WithMany()
                        .HasForeignKey("ArabalarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArabamDb_codeFirst.Muhendis", null)
                        .WithMany()
                        .HasForeignKey("MuhandislerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArabamDb_codeFirst.Araba", b =>
                {
                    b.HasOne("ArabamDb_codeFirst.Plaka", "Plaka")
                        .WithOne("Araba")
                        .HasForeignKey("ArabamDb_codeFirst.Araba", "PlakaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArabamDb_codeFirst.Sahip", "Sahip")
                        .WithMany("Arabalar")
                        .HasForeignKey("SahipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plaka");

                    b.Navigation("Sahip");
                });

            modelBuilder.Entity("ArabamDb_codeFirst.MuhendisAraba", b =>
                {
                    b.HasOne("ArabamDb_codeFirst.Araba", "Araba")
                        .WithMany("MuhendisArabalar")
                        .HasForeignKey("ArabaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArabamDb_codeFirst.Muhendis", "Muhendis")
                        .WithMany("MuhendisArabalar")
                        .HasForeignKey("MuhendisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Araba");

                    b.Navigation("Muhendis");
                });

            modelBuilder.Entity("ArabamDb_codeFirst.Araba", b =>
                {
                    b.Navigation("MuhendisArabalar");
                });

            modelBuilder.Entity("ArabamDb_codeFirst.Muhendis", b =>
                {
                    b.Navigation("MuhendisArabalar");
                });

            modelBuilder.Entity("ArabamDb_codeFirst.Plaka", b =>
                {
                    b.Navigation("Araba")
                        .IsRequired();
                });

            modelBuilder.Entity("ArabamDb_codeFirst.Sahip", b =>
                {
                    b.Navigation("Arabalar");
                });
#pragma warning restore 612, 618
        }
    }
}
