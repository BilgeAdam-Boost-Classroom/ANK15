using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UniversiteDBFirst.Models
{
    public partial class UniversiteDbContext : DbContext
    {
        public UniversiteDbContext()
        {
        }

        public UniversiteDbContext(DbContextOptions<UniversiteDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Danismanlar> Danismanlar { get; set; } = null!;
        public virtual DbSet<Dersler> Dersler { get; set; } = null!;
        public virtual DbSet<Diplomalar> Diplomalar { get; set; } = null!;
        public virtual DbSet<OgrenciDersler> OgrenciDersler { get; set; } = null!;
        public virtual DbSet<Ogrenciler> Ogrenciler { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-LAQPBG1\\MSSQLSERVER02;Database=UniversiteDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Danismanlar>(entity =>
            {
                entity.ToTable("Danismanlar");
            });

            modelBuilder.Entity<Dersler>(entity =>
            {
                entity.ToTable("Dersler");
            });

            modelBuilder.Entity<Diplomalar>(entity =>
            {
                entity.ToTable("Diplomalar");

                entity.Property(e => e.Tarih).HasColumnType("date");
            });

            modelBuilder.Entity<OgrenciDersler>(entity =>
            {
                entity.HasKey(e => new { e.OgrenciId, e.DersId });

                entity.ToTable("OgrenciDersler");

                entity.HasOne(d => d.Ders)
                    .WithMany(p => p.OgrenciDerslers)
                    .HasForeignKey(d => d.DersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OgrenciDersler_Dersler");

                entity.HasOne(d => d.Ogrenci)
                    .WithMany(p => p.OgrenciDerslers)
                    .HasForeignKey(d => d.OgrenciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OgrenciDersler_Ogrenciler");
            });

            modelBuilder.Entity<Ogrenciler>(entity =>
            {
                entity.ToTable("Ogrenciler");

                entity.HasIndex(e => e.DiplomaId, "IX_Ogrenciler")
                    .IsUnique();

                entity.HasIndex(e => e.Numara, "UQ__Ogrencil__7F5BF932A57944D9")
                    .IsUnique();

                entity.Property(e => e.Numara).HasMaxLength(8);

                entity.HasOne(d => d.Danisman)
                    .WithMany(p => p.Ogrencilers)
                    .HasForeignKey(d => d.DanismanId)
                    .HasConstraintName("FK_Ogrenciler_Danismanlar");

                entity.HasOne(d => d.Diploma)
                    .WithOne(p => p.Ogrenciler)
                    .HasForeignKey<Ogrenciler>(d => d.DiplomaId)
                    .HasConstraintName("FK_Ogrenciler_Ogrenciler");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
