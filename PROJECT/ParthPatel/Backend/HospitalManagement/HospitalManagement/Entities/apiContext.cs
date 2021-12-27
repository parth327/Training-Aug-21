using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalManagement.Entities
{
    public partial class apiContext : DbContext
    {
        public apiContext()
        {
        }

        public apiContext(DbContextOptions<apiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<AppointmentDoctor> AppointmentDoctor { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<DoctorDepartment> DoctorDepartment { get; set; }
        public virtual DbSet<Medicine> Medicine { get; set; }
        public virtual DbSet<MedicineSchedule> MedicineSchedule { get; set; }
        public virtual DbSet<MedicineSchedulePatient> MedicineSchedulePatient { get; set; }
        public virtual DbSet<Nurse> Nurse { get; set; }
        public virtual DbSet<NurseDepartment> NurseDepartment { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientDoctor> PatientDoctor { get; set; }
        public virtual DbSet<PatientDoctorNurse> PatientDoctorNurse { get; set; }
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<ReportPatientDoctor> ReportPatientDoctor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-TDGR3IJ;Database=api;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.Property(e => e.AppointmentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDate).HasColumnType("date");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OnCreated).HasColumnType("datetime");

                entity.Property(e => e.OnUpdated).HasColumnType("datetime");

                entity.Property(e => e.TimeSelection).HasColumnType("datetime");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__Appointme__Docto__4589517F");
            });

            modelBuilder.Entity<AppointmentDoctor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AppointmentDoctor");

                entity.Property(e => e.AppointmentDate).HasColumnType("date");

                entity.Property(e => e.AvailableFrom).HasColumnType("datetime");

                entity.Property(e => e.AvailableTo).HasColumnType("datetime");

                entity.Property(e => e.DoctorName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TimeSelection).HasColumnType("datetime");
            });

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

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OnCreated).HasColumnType("datetime");

                entity.Property(e => e.OnUpdated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.Property(e => e.DoctorId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AvailableFrom).HasColumnType("datetime");

                entity.Property(e => e.AvailableTo).HasColumnType("datetime");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DoctorName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OnCreated).HasColumnType("datetime");

                entity.Property(e => e.OnUpdated).HasColumnType("datetime");

                entity.Property(e => e.Speciality)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Doctor)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Doctor__Departme__3A179ED3");
            });

            modelBuilder.Entity<DoctorDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DoctorDepartment");

                entity.Property(e => e.AvailableFrom).HasColumnType("datetime");

                entity.Property(e => e.AvailableTo).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.Property(e => e.MedicineId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MedicineName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OnCreated).HasColumnType("datetime");

                entity.Property(e => e.OnUpdated).HasColumnType("datetime");
            });

            modelBuilder.Entity<MedicineSchedule>(entity =>
            {
                entity.Property(e => e.MedicineScheduleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.MedicineId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.NurseId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.OnCreated).HasColumnType("datetime");

                entity.Property(e => e.OnUpdated).HasColumnType("datetime");

                entity.Property(e => e.PatientId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.MedicineSchedule)
                    .HasForeignKey(d => d.MedicineId)
                    .HasConstraintName("FK__MedicineS__Medic__589C25F3");

                entity.HasOne(d => d.Nurse)
                    .WithMany(p => p.MedicineSchedule)
                    .HasForeignKey(d => d.NurseId)
                    .HasConstraintName("FK__MedicineS__Nurse__5C6CB6D7");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.MedicineSchedule)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__MedicineS__Patie__5A846E65");
            });

            modelBuilder.Entity<MedicineSchedulePatient>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MedicineSchedulePatient");

                entity.Property(e => e.MedicineName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nurse>(entity =>
            {
                entity.Property(e => e.NurseId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DepartmentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.NurseName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OnCreated).HasColumnType("datetime");

                entity.Property(e => e.OnUpdated).HasColumnType("datetime");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Nurse)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Nurse__Departmen__3FD07829");
            });

            modelBuilder.Entity<NurseDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NurseDepartment");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NurseName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.PatientId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.DoctorId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.NurseId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.OnCreated).HasColumnType("datetime");

                entity.Property(e => e.OnUpdated).HasColumnType("datetime");

                entity.Property(e => e.PatientName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__Patient__DoctorI__4D2A7347");

                entity.HasOne(d => d.Nurse)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.NurseId)
                    .HasConstraintName("FK__Patient__NurseId__4B422AD5");
            });

            modelBuilder.Entity<PatientDoctor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PatientDoctor");

                entity.Property(e => e.DoctorName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatientDoctorNurse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PatientDoctorNurse");

                entity.Property(e => e.DoctorName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NurseName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.Property(e => e.ReportId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OnCreated).HasColumnType("datetime");

                entity.Property(e => e.OnUpdated).HasColumnType("datetime");

                entity.Property(e => e.PatientId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Report)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__Report__PatientI__61316BF4");
            });

            modelBuilder.Entity<ReportPatientDoctor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ReportPatientDoctor");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
