using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal.Models;

public partial class GymContext : DbContext
{
    public GymContext()
    {
    }

    public GymContext(DbContextOptions<GymContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Excersizer> Excersizers { get; set; }

    public virtual DbSet<Insurance> Insurances { get; set; }

    public virtual DbSet<Lesson> Lessons { get; set; }

    public virtual DbSet<Trainer> Trainers { get; set; }

    public virtual DbSet<TypeOfTraining> TypeOfTrainings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\C#\\GymProject\\MyProject\\DB\\Gym.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
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
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Excersizers_Insurance");

            entity.HasOne(d => d.TrainerCodeNavigation).WithMany(p => p.Excersizers)
                .HasForeignKey(d => d.TrainerCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Excersizers_Trainers");
        });

        modelBuilder.Entity<Insurance>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Insuranc__A25C5AA694B1F637");

            entity.ToTable("Insurance");

            entity.Property(e => e.InsuranceName).HasMaxLength(50);
        });

        modelBuilder.Entity<Lesson>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07AB101533");

            entity.HasOne(d => d.Excersizer).WithMany(p => p.Lessons)
                .HasForeignKey(d => d.ExcersizerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Excersizer_Lesson");

            entity.HasOne(d => d.Trainer).WithMany(p => p.Lessons)
                .HasForeignKey(d => d.TrainerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Trainer_Lesson");
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
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Trainers_TypeOfTraining");
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
