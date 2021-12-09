using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalAuth.Entity
{
    public partial class HospitalAuthDBContext : DbContext
    {
        public HospitalAuthDBContext()
        {
        }

        public HospitalAuthDBContext(DbContextOptions<HospitalAuthDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
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
                optionsBuilder.UseSqlServer("Server=DESKTOP-TDGR3IJ;Database=HospitalAuthDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Assistent>(entity =>
            {
                entity.HasIndex(e => e.DepartmentId);

                entity.HasIndex(e => e.DoctorId);

                entity.Property(e => e.AssistentId).ValueGeneratedNever();

                entity.Property(e => e.AssistentName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Assistent)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Assistent__Depar__2A4B4B5E");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Assistent)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__Assistent__Docto__29572725");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId).ValueGeneratedNever();

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasIndex(e => e.DepartmentId);

                entity.Property(e => e.DoctorId).ValueGeneratedNever();

                entity.Property(e => e.DoctorName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Doctor)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Doctor__Departme__267ABA7A");
            });

            modelBuilder.Entity<DoctorPatient>(entity =>
            {
                entity.HasIndex(e => e.DoctorId);

                entity.HasIndex(e => e.PatientId);

                entity.Property(e => e.DoctorPatientId).ValueGeneratedNever();

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DoctorPatient)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__DoctorPat__Docto__33D4B598");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.DoctorPatient)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__DoctorPat__Patie__32E0915F");
            });

            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.Property(e => e.MedicineId).ValueGeneratedNever();

                entity.Property(e => e.MedicineName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasIndex(e => e.AssistentId);

                entity.HasIndex(e => e.DoctorId);

                entity.Property(e => e.PatientId).ValueGeneratedNever();

                entity.Property(e => e.PatientName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Assistent)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.AssistentId)
                    .HasConstraintName("FK__Patient__Assiste__2D27B809");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__Patient__DoctorI__2E1BDC42");
            });

            modelBuilder.Entity<PatientMedicineList>(entity =>
            {
                entity.HasIndex(e => e.MedicineId);

                entity.HasIndex(e => e.PatientId);

                entity.Property(e => e.PatientMedicineListId).ValueGeneratedNever();

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.PatientMedicineList)
                    .HasForeignKey(d => d.MedicineId)
                    .HasConstraintName("FK__PatientMe__Medic__37A5467C");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientMedicineList)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__PatientMe__Patie__36B12243");
            });

            modelBuilder.Entity<PatientReport>(entity =>
            {
                entity.HasIndex(e => e.PatientId);

                entity.Property(e => e.PatientReportId).ValueGeneratedNever();

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientReport)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__PatientRe__Patie__3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
