using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalManagement.Entities
{
    public partial class Patient
    {
        public Patient()
        {
            MedicineSchedule = new HashSet<MedicineSchedule>();
            Report = new HashSet<Report>();
        }

        public Guid PatientId { get; set; }
        public string PatientName { get; set; }
        public DateTime? Dob { get; set; }
        public int? Age { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public Guid? NurseId { get; set; }
        public Guid? DoctorId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? OnCreated { get; set; }
        public DateTime? OnUpdated { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual Nurse Nurse { get; set; }
        public virtual ICollection<MedicineSchedule> MedicineSchedule { get; set; }
        public virtual ICollection<Report> Report { get; set; }
    }
}
