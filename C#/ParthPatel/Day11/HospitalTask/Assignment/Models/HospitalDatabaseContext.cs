using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HospitalTask.Assignment.Models
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
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<DoctorPatient> DoctorPatient { get; set; }
        public virtual DbSet<Medicine> Medicine { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientMedicineList> PatientMedicineList { get; set; }
        public virtual DbSet<PatientReport> PatientReport { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-RG242EI\SQLEXPRESS;Database=HospitalDatabase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assistent>(entity =>
            {
                entity.Property(e => e.AssistentId)
                    .HasColumnName("AssistentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssistentName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Assistent)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__Assistent__Docto__300424B4");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.Property(e => e.DoctorId)
                    .HasColumnName("DoctorID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DoctorName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Doctor)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Doctor__Departme__2A4B4B5E");
            });

            modelBuilder.Entity<DoctorPatient>(entity =>
            {
                entity.Property(e => e.DoctorPatientId)
                    .HasColumnName("DoctorPatientID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DoctorPatient)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__DoctorPat__Docto__412EB0B6");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.DoctorPatient)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__DoctorPat__Patie__403A8C7D");
            });

            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.Property(e => e.MedicineId)
                    .HasColumnName("MedicineID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MedicineName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.PatientId)
                    .HasColumnName("PatientID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssistentId).HasColumnName("AssistentID");

                entity.Property(e => e.PatientName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Assistent)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.AssistentId)
                    .HasConstraintName("FK__Patient__Assiste__36B12243");
            });

            modelBuilder.Entity<PatientMedicineList>(entity =>
            {
                entity.HasKey(e => e.ListId)
                    .HasName("PK__PatientM__E3832865CDC5DD45");

                entity.Property(e => e.ListId)
                    .HasColumnName("ListID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MedicineId).HasColumnName("MedicineID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.PatientMedicineList)
                    .HasForeignKey(d => d.MedicineId)
                    .HasConstraintName("FK__PatientMe__Medic__3A81B327");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientMedicineList)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__PatientMe__Patie__398D8EEE");
            });

            modelBuilder.Entity<PatientReport>(entity =>
            {
                entity.Property(e => e.PatientReportId)
                    .HasColumnName("PatientReportID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientReport)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__PatientRe__Patie__3D5E1FD2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
