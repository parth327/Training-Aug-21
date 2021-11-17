using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HospitalDatabase.Models
{
    public partial class HospitalDatabaseContext : DbContext
    {
        public HospitalDatabaseContext()
        {
        }

        public HospitalDatabaseContext(DbContextOptions<HospitalDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Assistent> Assistent { get; set; }
        public virtual DbSet<DoctorPatient> DoctorPatient  { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Medicine> Medicine { get; set; }
        public virtual DbSet<PatientMedicineList> PatientMedicineList  { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientReport> Patientreport { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-RG242EI\\SQLEXPRESS;Database=HospitalDatabase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Assistent>(entity =>
            {
                entity.Property(e => e.AssistentName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.AssistentID)
                    .HasForeignKey(d => d.DoctorID)
                    .HasConstraintName("FK_Assistant_DoctorID");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.Property(e => e.DoctorName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.DoctoID)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Doctor_DepartmentID");
            });

            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.Property(e => e.MedicineName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatientMedicineList>(entity =>
            {
                entity.Property(e => e.MedicineID).HasColumnName("MedicineID");

                entity.Property(e => e.PatientID).HasColumnName("PatientID");

                entity.Property(e => e.Daypart).HasColumnName("Daypart");

                entity.HasOne(d => d.Daypart)
                    .WithMany(p => p.MedicineID)
                    .withMany(p => p.PatientID)
                    .HasForeignKey(d => d.PatientID)
                    .HasForeignKey(d => d.MedicineID)
                    .HasConstraintName("FK_PatientMedicineList_PatientId")
                    .HasConstraintName("FK_PatientMedicineList_MedicineId");

                entity.HasOne(d => d.MedicineID)
                    .WithMany(p => p.PatientID);

                entity.HasOne(d => d.PatientID)
                    .WithMany(p => p.MedicineId);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.PatientName)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.AssistentID)
                    .HasForeignKey(d => d.AssistentId)
                    .HasConstraintName("FK_Patient_AssistentID");

            });

            modelBuilder.Entity<PatientReport>(entity =>
            {
                
                entity.Property(e => e.BloodPressure).HasColumnName("BloodPressure");

                entity.Property(e => e.Sugar).HasColumnName("Sugar");

                entity.Property(e => e.Hearbit).HasColumnName("Heartbit");

                entity.Property(e => e.HealthStatus).HasColumnName("HealthStatus");

                entity.Property(e => e.PatientID).HasColumnName("PatientID");

                entity.HasOne(d => d.BloodPressure)
                entity.HasOne(d => d.Sugar)
                entity.HasOne(d => d.Heartbit)
                entity.HasOne(d => d.HealthStatus)
                .HasForeignKey(d => d.PatientID)
                .HasConstraintName("FK_PatientReport_PatientId");

            });

            modelBuilder.Entity<DoctorPatient>(entity =>
            {
                entity.HasOne(d => d.DoctorID)
                    .WithMany(p => p.PatientID)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_DoctorPatient_PatientID");

                entity.HasOne(d => d.PatientID)
                    .WithMany(p => p.DoctorID)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_DoctorPatient_DoctorID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
