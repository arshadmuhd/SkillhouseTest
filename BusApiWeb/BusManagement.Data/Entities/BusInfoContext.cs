using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BusManagement.Data.Entities;

public partial class BusInfoContext : DbContext
{
    public BusInfoContext()
    {
    }

    public BusInfoContext(DbContextOptions<BusInfoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblBu> TblBus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=BusInfo;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblBu>(entity =>
        {
            entity.HasKey(e => e.BusNumber).HasName("PK__tblBus__41D29184AFA3A104");

            entity.ToTable("tblBus");

            entity.Property(e => e.BusNumber).ValueGeneratedNever();
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
