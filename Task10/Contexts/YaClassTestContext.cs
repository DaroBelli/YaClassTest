using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Task10.Models.DB;

namespace Task10.Contexts;

public partial class YaClassTestContext : DbContext
{
    public YaClassTestContext()
    {
    }

    public YaClassTestContext(DbContextOptions<YaClassTestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Deposit> Deposits { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=YaClassTest;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Deposit>(entity =>
        {
            entity
                .ToTable("deposits");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.InitialDeposit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("initial_deposit");
            entity.Property(e => e.MonthCount).HasColumnName("month_count");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
