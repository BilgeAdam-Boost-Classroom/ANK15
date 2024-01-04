using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Example_User_Add.Models;

public partial class UniversiteDbContext : DbContext
{
    public UniversiteDbContext()
    {
    }

    public UniversiteDbContext(DbContextOptions<UniversiteDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Danismanlar> Danismanlars { get; set; }

    public virtual DbSet<Dersler> Derslers { get; set; }

    public virtual DbSet<Diplomalar> Diplomalars { get; set; }

    public virtual DbSet<OgrenciDersler> OgrenciDerslers { get; set; }

    public virtual DbSet<Ogrenciler> Ogrencilers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=P96ANV;Database=UniversiteDb;Trusted_Connection=True;TrustServerCertificate=True;");

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
        });

        modelBuilder.Entity<OgrenciDersler>(entity =>
        {
            entity.HasKey(e => new { e.OgrenciId, e.DersId });

            entity.ToTable("OgrenciDersler");

            entity.HasOne(d => d.Ders).WithMany(p => p.OgrenciDerslers)
                .HasForeignKey(d => d.DersId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OgrenciDersler_Dersler");

            entity.HasOne(d => d.Ogrenci).WithMany(p => p.OgrenciDerslers)
                .HasForeignKey(d => d.OgrenciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OgrenciDersler_Ogrenciler");
        });

        modelBuilder.Entity<Ogrenciler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ogrencil__3214EC07D44C9B42");

            entity.ToTable("Ogrenciler");

            entity.HasIndex(e => e.DiplomaId, "IX_Ogrenciler").IsUnique();

            entity.HasIndex(e => e.Numara, "UQ__Ogrencil__7F5BF932A57944D9").IsUnique();

            entity.Property(e => e.Numara).HasMaxLength(8);

            entity.HasOne(d => d.Danisman).WithMany(p => p.Ogrencilers)
                .HasForeignKey(d => d.DanismanId)
                .HasConstraintName("FK_Ogrenciler_Danismanlar");

            entity.HasOne(d => d.Diploma).WithOne(p => p.Ogrenciler)
                .HasForeignKey<Ogrenciler>(d => d.DiplomaId)
                .HasConstraintName("FK_Ogrenciler_Ogrenciler");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
