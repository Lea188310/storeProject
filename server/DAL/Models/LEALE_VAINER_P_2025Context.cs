using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class LEALE_VAINER_P_2025Context : DbContext
    {
        public LEALE_VAINER_P_2025Context()
        {
        }

        public LEALE_VAINER_P_2025Context(DbContextOptions<LEALE_VAINER_P_2025Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Custemer> Custemers { get; set; } = null!;
        public virtual DbSet<Game> Games { get; set; } = null!;
        public virtual DbSet<Shopping> Shoppings { get; set; } = null!;
        public virtual DbSet<ShoppingDetail> ShoppingDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=kitotSrv\\sql;Database= LEALE_VAINER_P_2025;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategorId)
                    .HasName("PK__Category__08026387B47115EA");

                entity.ToTable("Category");

                entity.Property(e => e.CategorId).HasColumnName("CategorID");

                entity.Property(e => e.CategoryName).HasMaxLength(100);
            });

            modelBuilder.Entity<Custemer>(entity =>
            {
                entity.ToTable("Custemer");

                entity.Property(e => e.CustemerId).HasColumnName("CustemerID");

                entity.Property(e => e.CreditDetails).HasMaxLength(100);

                entity.Property(e => e.CustName).HasMaxLength(100);

                entity.Property(e => e.CustPassword).HasMaxLength(100);
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.Property(e => e.CategorId).HasColumnName("CategorID");

                entity.Property(e => e.Pecture).HasMaxLength(225);

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.HasOne(d => d.Categor)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.CategorId)
                    .HasConstraintName("FK__Games__CategorID__398D8EEE");
            });

            modelBuilder.Entity<Shopping>(entity =>
            {
                entity.ToTable("Shopping");

                entity.Property(e => e.ShoppingId).HasColumnName("ShoppingID");

                entity.Property(e => e.CustemerId).HasColumnName("CustemerID");

                entity.Property(e => e.DateShopping).HasColumnType("date");

                entity.HasOne(d => d.Custemer)
                    .WithMany(p => p.Shoppings)
                    .HasForeignKey(d => d.CustemerId)
                    .HasConstraintName("FK__Shopping__Custem__3E52440B");
            });

            modelBuilder.Entity<ShoppingDetail>(entity =>
            {
                entity.HasKey(e => e.ShoppingDetailsId)
                    .HasName("PK__Shopping__08D34F9E46021A32");

                entity.Property(e => e.ShoppingDetailsId).HasColumnName("ShoppingDetailsID");

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.Property(e => e.ShoppingId).HasColumnName("ShoppingID");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.ShoppingDetails)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("FK__ShoppingD__Games__5165187F");

                entity.HasOne(d => d.Shopping)
                    .WithMany(p => p.ShoppingDetails)
                    .HasForeignKey(d => d.ShoppingId)
                    .HasConstraintName("FK__ShoppingD__Shppi__5070F446");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
