using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TestDAL.Seeds;

namespace TestDAL.Models
{
    public partial class NovoBITestDBContext : DbContext
    {
        public NovoBITestDBContext()
        {
        }

        public NovoBITestDBContext(DbContextOptions<NovoBITestDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookOrders> BookOrders { get; set; }
        public virtual DbSet<BookTypes> BookTypes { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<DiscContents> DiscContents { get; set; }
        public virtual DbSet<DiscOrders> DiscOrders { get; set; }
        public virtual DbSet<DiscTypes> DiscTypes { get; set; }
        public virtual DbSet<Discs> Discs { get; set; }
        public virtual DbSet<OrderStatuses> OrderStatuses { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=NovoBITestDB;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookOrders>(entity =>
            {
                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookOrders)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookOrders_Books");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.BookOrders)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_BookOrders_Orders");
            });

            modelBuilder.Entity<BookTypes>(entity =>
            {
                entity.Property(e => e.BookTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ExtraData)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.BookType)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.BookTypeId)
                    .HasConstraintName("FK_Books_BookTypes");
            });

            modelBuilder.Entity<DiscContents>(entity =>
            {
                entity.Property(e => e.DiscContentName).HasMaxLength(50);
            });

            modelBuilder.Entity<DiscOrders>(entity =>
            {
                entity.HasOne(d => d.Disc)
                    .WithMany(p => p.DiscOrders)
                    .HasForeignKey(d => d.DiscId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiscOrders_Discs");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.DiscOrders)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_DiscOrders_Orders");
            });

            modelBuilder.Entity<DiscTypes>(entity =>
            {
                entity.Property(e => e.DiscTypeName)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Discs>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.DiscContent)
                    .WithMany(p => p.Discs)
                    .HasForeignKey(d => d.DiscContentId)
                    .HasConstraintName("FK_Discs_DiscContents");

                entity.HasOne(d => d.DiscType)
                    .WithMany(p => p.Discs)
                    .HasForeignKey(d => d.DiscTypeId)
                    .HasConstraintName("FK_Discs_DiscTypes");
            });

            modelBuilder.Entity<OrderStatuses>(entity =>
            {
                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.Property(e => e.ClientEmail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderStatusId)
                    .HasConstraintName("FK_Orders_OrdersStatuses");
            });
            modelBuilder.Seed();
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
