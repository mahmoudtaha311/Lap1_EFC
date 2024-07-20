using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lap1_EFC.Models;

public partial class TransactionContext : DbContext
{
    public TransactionContext()
    {
    }

    public TransactionContext(DbContextOptions<TransactionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrdersItem> OrdersItems { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=Transaction;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemName)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.User).WithMany(p => p.Orders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Orders_Users");
        });

        modelBuilder.Entity<OrdersItem>(entity =>
        {
            entity.HasKey(e => new { e.Orderid, e.Itemid });

            entity.ToTable("Orders_Items");

            entity.Property(e => e.Orderid).HasColumnName("orderid");
            entity.Property(e => e.Itemid).HasColumnName("itemid");

            entity.HasOne(d => d.Item).WithMany(p => p.OrdersItems)
                .HasForeignKey(d => d.Itemid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Items_Items");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
