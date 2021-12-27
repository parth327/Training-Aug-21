using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalManagement.Entities
{
    public partial class Nurse
    {
        public Nurse()
        {
            MedicineSchedule = new HashSet<MedicineSchedule>();
            Patient = new HashSet<Patient>();
        }

        public Guid NurseId { get; set; }
        public string NurseName { get; set; }
        public Guid? DepartmentId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? OnCreated { get; set; }
        public DateTime? OnUpdated { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<MedicineSchedule> MedicineSchedule { get; set; }
        public virtual ICollection<Patient> Patient { get; set; }
    }
}
