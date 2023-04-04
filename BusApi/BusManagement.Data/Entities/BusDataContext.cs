using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BusManagement.Data.Entities;

public partial class BusDataContext : DbContext
{
    public BusDataContext()
    {
    }

    public BusDataContext(DbContextOptions<BusDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblBusInfo> TblBusInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("\nServer=.;Database=BusData;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblBusInfo>(entity =>
        {
            entity.HasKey(e => e.BusNumber).HasName("PK__tblBusIn__41D29184A4F85BFC");

            entity.ToTable("tblBusInfo");

            entity.Property(e => e.BusNumber).ValueGeneratedNever();
            entity.Property(e => e.Arrival).HasColumnType("datetime");
            entity.Property(e => e.Departure).HasColumnType("datetime");
            entity.Property(e => e.Destination)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.SourceCity)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
