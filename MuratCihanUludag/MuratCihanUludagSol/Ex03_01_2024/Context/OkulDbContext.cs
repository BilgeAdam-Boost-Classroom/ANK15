using Ex03_01_2024.Models;
using Microsoft.EntityFrameworkCore;


namespace Ex03_01_2024.Context
{
    public class OkulDbContext : DbContext
    {
        public OkulDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=P96ANV;Database=Okul2Db;Trusted_Connection=True;TrustServerCertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ogrenci>().HasOne(o => o.Diploma)
                                          .WithOne(d => d.Ogrenci)
                                          .HasForeignKey<Ogrenci>(d => d.DanismanYabanciAnahtar)
                                          .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Sube>().HasIndex(i => i.Ad)
                                       .IsUnique();

            modelBuilder.Entity<Sube>().ToTable("Section");

            modelBuilder.Entity<Sube>().HasKey(i => i.SubePrimaryKey);

            modelBuilder.Entity<Laboratuvar>().HasKey(i => i.L1);

            modelBuilder.Entity<Laboratuvar>().Property(p => p.L1).HasColumnName("L2");

            modelBuilder.Entity<Laboratuvar>().Ignore(p => p.Tanim);

            modelBuilder.Entity<Sube>().Property(p => p.Aciklama)
                                       .HasColumnType("nvarchar(250)");


            modelBuilder.Entity<Ogrenci>().HasOne(o => o.Sube)
                                          .WithMany(d => d.Ogrenciler)
                                          .HasForeignKey(o => o.SubeYabanciAnahtar);


            modelBuilder.Entity<Ogrenci>().HasOne(o => o.Transcript)
                                          .WithOne(w => w.Ogrenci)
                                          .HasForeignKey<Ogrenci>(o => o.KarneId);

            modelBuilder.Entity<YazarKitap>().HasOne(o => o.Author)
                                             .WithMany(m => m.YazarKitaplar)
                                             .HasForeignKey(f => f.AuthorId);

            modelBuilder.Entity<YazarKitap>().HasOne(o => o.Book)
                                             .WithMany(m => m.YazarKitaplar)
                                             .HasForeignKey(f => f.BookId);

            modelBuilder.Entity<YazarKitap>().HasKey(p => new { p.AuthorId, p.BookId });

            modelBuilder.Entity<KutuphaneKitap>().HasOne(h => h.Kitap)
                                                 .WithMany(m => m.KutuphaneKitaplar)
                                                 .HasForeignKey(fk => fk.BookNo);

            modelBuilder.Entity<KutuphaneKitap>().HasOne(h => h.Kutuphane)
                                                 .WithMany(m => m.KutuphaneKitaplar)
                                                 .HasForeignKey(fk => fk.LiblaryNo);

            modelBuilder.Entity<KutuphaneKitap>().HasKey(pk => new { pk.LiblaryNo, pk.BookNo });

            modelBuilder.Entity<Kitap>().HasOne(h => h.Bandrol)
                                        .WithOne(w => w.Kitap)
                                        .HasForeignKey<Kitap>(fk => fk.BandrolNo);

            modelBuilder.Entity<Kitap>().HasOne(h => h.YayinEvi)
                                        .WithMany(w => w.Kitaplar)
                                        .HasForeignKey(fk => fk.YayinNo);

            /*
             * 1.Loading turleri nelerdir? Kisaca aciklayiniz.
             * 
             * Loading turler Lazy Loading ve Eager Loading'tir.
             * 
             * Lazy Loading  verileri iliskisi oldukca cekmemizi saglar.
             * 
             * Eager Loading ise direk tum sorguyu cekmemizi saglar (Tek sorgu Halinde)
             * 
             * Lazy Loading kullanmamiz icin oncelikle  iliski kurulmus sinifi virtual (Sanal) olarak etiketlememiz gerekir. Sorgu geriDonusu olarak IQueryable dir
             * 
             * Eager Loading ise sorguyu tek seferde yikler ve bellekte calistirir. Donus tipi de IEnumerable dir.
             * 
             * 2.Include ile ThenInclude arasinda ki fark nedir.
             * 
             * Include ile thenInclude arasinda ki fark include iliski kurulurken tek seferde bir yukleme yapilacagi zaman kullanilir. ThenInclude ise birbirne bagli birden fazla  iliski varsa ve sira onemliyse birbirlerine thenInclude ile baglanarak veri tabindan sorguyu sira sira ceker.
             */
        }

        public DbSet<Diploma> Diplomas { get; set; }
        public DbSet<Ogrenci> Orenciler { get; set; }
        public DbSet<Danisman> Danismanlar { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<OgrenciDers> OgrenciDerses { get; set; }
        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet<Sube> Subeler { get; set; }
        public DbSet<Laboratuvar> Laboratuvarlar { get; set; }
        public DbSet<Transcript> Transcripts { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<YazarKitap> YazarKitaplar { get; set; }
        public DbSet<Bandrol> Bandroller { get; set; }
        public DbSet<Kutuphane> Kutuphaneler { get; set; }
        public DbSet<KutuphaneKitap> KutuphaneKitaplar { get; set; }
        public DbSet<YayinEvi> YayinEviler { get; set; }
    }
}
