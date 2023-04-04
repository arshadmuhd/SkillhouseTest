using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data.Entities;

public partial class EmployeeMangamentSysytemContext : DbContext
{
    public EmployeeMangamentSysytemContext()
    {
    }

    public EmployeeMangamentSysytemContext(DbContextOptions<EmployeeMangamentSysytemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblEmp> TblEmps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=EmployeeMangamentSysytem;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblEmp>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("TblEmp");

            entity.Property(e => e.EmpId).ValueGeneratedNever();
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
