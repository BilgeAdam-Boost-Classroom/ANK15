﻿// <auto-generated />
using LodingChangeTracker.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LodingChangeTracker.Migrations
{
    [DbContext(typeof(UygulamaDbContext))]
    [Migration("20240111062818_m1")]
    partial class m1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LodingChangeTracker.Concrete.Lisans", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Numara")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lisans");
                });

            modelBuilder.Entity("LodingChangeTracker.Concrete.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LisansId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LisansId")
                        .IsUnique();

                    b.ToTable("Uruns");
                });

            modelBuilder.Entity("LodingChangeTracker.Concrete.Urun", b =>
                {
                    b.HasOne("LodingChangeTracker.Concrete.Lisans", "Lisans")
                        .WithOne("Urun")
                        .HasForeignKey("LodingChangeTracker.Concrete.Urun", "LisansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lisans");
                });

            modelBuilder.Entity("LodingChangeTracker.Concrete.Lisans", b =>
                {
                    b.Navigation("Urun")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
