using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AssetsAPI_Natalie.Models
{
    public partial class P6AssetsContext : DbContext
    {
        public P6AssetsContext()
        {
        }

        public P6AssetsContext(DbContextOptions<P6AssetsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activo> Activos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("SERVER=DESKTOP-FDRGAC6 ;DATABASE=P6Assets; User Id=AssetsUser; Password=pvI20221");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activo>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Activo__06370DADCECD07DE");

                entity.ToTable("Activo");

                entity.Property(e => e.Area)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CostoActivo).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.NombreActivo)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
