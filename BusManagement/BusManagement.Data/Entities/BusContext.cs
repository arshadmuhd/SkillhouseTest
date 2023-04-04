using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BusManagement.Data.Entities;

public partial class BusContext : DbContext
{
    public BusContext()
    {
    }

    public BusContext(DbContextOptions<BusContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblBu> TblBus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=Bus;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblBu>(entity =>
        {
            entity.HasKey(e => e.BusNumber).HasName("PK__tblBus__41D29184D8D190D2");

            entity.ToTable("tblBus");

            entity.Property(e => e.BusNumber).ValueGeneratedNever();
            entity.Property(e => e.BusArrival).HasColumnType("datetime");
            entity.Property(e => e.BusDeparture).HasColumnType("datetime");
            entity.Property(e => e.BusDestinationCity)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BusSourceCity)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.BusType)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
