using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CafeAppSql;

public partial class CafeDataBaseContext : DbContext
{
    public CafeDataBaseContext()
    {
    }

    public CafeDataBaseContext(DbContextOptions<CafeDataBaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Dish> Dishes { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<OrderSummary> OrderSummaries { get; set; }

    public virtual DbSet<Waiter> Waiters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CafeDataBase;Username=postgres;Password=02122016");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoriesId).HasName("categories_pkey");

            entity.ToTable("categories");

            entity.Property(e => e.CategoriesId).HasColumnName("categories_id");
            entity.Property(e => e.CategoriesName).HasColumnName("categories_name");
        });

        modelBuilder.Entity<Dish>(entity =>
        {
            entity.HasKey(e => e.DishId).HasName("dishes_pkey");

            entity.ToTable("dishes");

            entity.Property(e => e.DishId).HasColumnName("dish_id");
            entity.Property(e => e.CategoriesId).HasColumnName("categories_id");
            entity.Property(e => e.DishName).HasColumnName("dish_name");
            entity.Property(e => e.DishPrice)
                .HasPrecision(10, 2)
                .HasColumnName("dish_price");

            entity.HasOne(d => d.Categories).WithMany(p => p.Dishes)
                .HasForeignKey(d => d.CategoriesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dishes_categories_id_fkey");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("orders_pkey");

            entity.ToTable("orders");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.OrderTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("order_time");
            entity.Property(e => e.WaiterId).HasColumnName("waiter_id");

            entity.HasOne(d => d.Waiter).WithMany(p => p.Orders)
                .HasForeignKey(d => d.WaiterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("orders_waiter_id_fkey");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("order_items");

            entity.Property(e => e.DishId).HasColumnName("dish_id");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Dish).WithMany()
                .HasForeignKey(d => d.DishId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("order_items_dish_id_fkey");

            entity.HasOne(d => d.Order).WithMany()
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("order_items_order_id_fkey");
        });

        modelBuilder.Entity<OrderSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("order_summary");

            entity.Property(e => e.ДатаЗаказа)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("дата_заказа");
            entity.Property(e => e.КоличествоБлюд).HasColumnName("количество_блюд");
            entity.Property(e => e.НомерЗаказа).HasColumnName("номер_заказа");
            entity.Property(e => e.Официант).HasColumnName("официант");
            entity.Property(e => e.СуммаЗаказа).HasColumnName("сумма_заказа");
        });

        modelBuilder.Entity<Waiter>(entity =>
        {
            entity.HasKey(e => e.WaiterId).HasName("waiters_pkey");

            entity.ToTable("waiters");

            entity.Property(e => e.WaiterId).HasColumnName("waiter_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Post)
                .HasDefaultValueSql("false")
                .HasColumnName("post");
            entity.Property(e => e.WaiterLastname).HasColumnName("waiter_lastname");
            entity.Property(e => e.WaiterName).HasColumnName("waiter_name");
            entity.Property(e => e.WaiterPatronymic).HasColumnName("waiter_patronymic");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
