using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MvcTest.Data.Postgres.DataAccess.Entities;

namespace MvcTest.Data.Postgres.DataAccess.Context;

public partial class MachineDataContext : DbContext
{
    public MachineDataContext()
    {
    }

    public MachineDataContext(DbContextOptions<MachineDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Machine> Machines { get; set; }

    public virtual DbSet<MachineAssignment> MachineAssignments { get; set; }

    public virtual DbSet<SerialNumber> SerialNumbers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresEnum("app_service", "app_category", new[] { "external", "internal" })
            .HasPostgresEnum("app_service", "app_presentation", new[] { "large", "menu_link", "short_link", "small", "widget" })
            .HasPostgresEnum("app_service", "app_type", new[] { "headless", "my_tracto", "system", "third_party" })
            .HasPostgresEnum("app_service", "settings_control_type", new[] { "boolean", "date_time", "drop_down", "heading", "integer", "multiline_text", "text" })
            .HasAnnotation("Npgsql:CollationDefinition:public.appservice_case_insensitive_collation", "C.utf8,C.utf8,icu,False")
            .HasAnnotation("Npgsql:CollationDefinition:public.machineservice_case_insensitive_collation", "C.utf8,C.utf8,icu,False");

        modelBuilder.Entity<Machine>(entity =>
        {
            entity.ToTable("machines", "machine_service");

            entity.HasIndex(e => e.SerialNumberId, "IX_machines_serial_number_id").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ApprovedById).HasColumnName("approved_by_id");
            entity.Property(e => e.ApprovedByName)
                .HasMaxLength(200)
                .HasColumnName("approved_by_name");
            entity.Property(e => e.SerialNumberId).HasColumnName("serial_number_id");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");

            entity.HasOne(d => d.SerialNumber).WithOne(p => p.Machine)
                .HasForeignKey<Machine>(d => d.SerialNumberId)
                .HasConstraintName("FK_machines_serial_numbers");
        });

        modelBuilder.Entity<MachineAssignment>(entity =>
        {
            entity.ToTable("machine_assignments", "machine_service");

            entity.HasIndex(e => e.MachineId, "IX_machine_assignments_machine_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.DateCreated).HasColumnName("date_created");
            entity.Property(e => e.EuDataActAccepted)
                .HasDefaultValue(true)
                .HasColumnName("eu_data_act_accepted");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(1200)
                .UseCollation("machineservice_case_insensitive_collation")
                .HasColumnName("image_url");
            entity.Property(e => e.IsHidden).HasColumnName("is_hidden");
            entity.Property(e => e.IsSold).HasColumnName("is_sold");
            entity.Property(e => e.MachineDescription)
                .UseCollation("machineservice_case_insensitive_collation")
                .HasColumnName("machine_description");
            entity.Property(e => e.MachineId).HasColumnName("machine_id");
            entity.Property(e => e.MachineName)
                .HasMaxLength(200)
                .UseCollation("machineservice_case_insensitive_collation")
                .HasColumnName("machine_name");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.OwnerName)
                .HasMaxLength(200)
                .HasColumnName("owner_name");
            entity.Property(e => e.ProofOfPurchaseUrl)
                .HasMaxLength(1200)
                .UseCollation("machineservice_case_insensitive_collation")
                .HasColumnName("proof_of_purchase_url");
            entity.Property(e => e.PurchaseDate).HasColumnName("purchase_date");
            entity.Property(e => e.SellDate).HasColumnName("sell_date");
            entity.Property(e => e.ThumbnailUrl)
                .HasMaxLength(1200)
                .UseCollation("machineservice_case_insensitive_collation")
                .HasColumnName("thumbnail_url");

            entity.HasOne(d => d.Machine).WithMany(p => p.MachineAssignments)
                .HasForeignKey(d => d.MachineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_machine_assignments_machines");
        });

        modelBuilder.Entity<SerialNumber>(entity =>
        {
            entity.ToTable("serial_numbers", "machine_service");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .UseCollation("machineservice_case_insensitive_collation")
                .HasColumnName("number");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
