using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal.Models;

public partial class GymContext : DbContext
{
    public GymContext(DbContextOptions<GymContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Excersizer> Excersizers { get; set; }

    public virtual DbSet<Insurance> Insurances { get; set; }

    public virtual DbSet<Trainer> Trainers { get; set; }

    public virtual DbSet<TrainersWorkingDay> TrainersWorkingDays { get; set; }

    public virtual DbSet<TypeOfTraining> TypeOfTrainings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Appointm__3214EC07A4C4E446");

            entity.Property(e => e.Hour).HasColumnType("datetime");

            entity.HasOne(d => d.Excersizer).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.ExcersizerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Excersizer_Appointment");

            entity.HasOne(d => d.TrainerCodeNavigation).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.TrainerCode)
                .HasConstraintName("FK_Trainer_Appointment");
        });

        modelBuilder.Entity<Excersizer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC0759959953");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.InsuranceCodeNavigation).WithMany(p => p.Excersizers)
                .HasForeignKey(d => d.InsuranceCode)
                .HasConstraintName("FK_Excersizers_Insurance");
        });

        modelBuilder.Entity<Insurance>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Insuranc__A25C5AA694B1F637");

            entity.ToTable("Insurance");

            entity.Property(e => e.InsuranceName).HasMaxLength(50);
        });

        modelBuilder.Entity<Trainer>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__tmp_ms_x__A25C5AA6607ADB41");

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.TypeOfTrainingCodeNavigation).WithMany(p => p.Trainers)
                .HasForeignKey(d => d.TypeOfTrainingCode)
                .HasConstraintName("FK_Trainers_TypeOfTraining");
        });

        modelBuilder.Entity<TrainersWorkingDay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Trainers__3214EC070FD33F62");
        });

        modelBuilder.Entity<TypeOfTraining>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__tmp_ms_x__A25C5AA66DD2321A");

            entity.ToTable("TypeOfTraining");

            entity.Property(e => e.TrainingName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
