using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalManagement.Models
{
    public partial class MedicineScheduleModel
    {
        public Guid MedicineScheduleId { get; set; }
        public Guid? MedicineId { get; set; }
        public bool? DayPartMorning { get; set; }
        public bool? DayPartNoon { get; set; }
        public bool? DayPartEvening { get; set; }
        public Guid? PatientId { get; set; }
        public Guid? NurseId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? OnCreated { get; set; }
        public DateTime? OnUpdated { get; set; }

        public virtual MedicineModel Medicine { get; set; }
        public virtual NurseModel Nurse { get; set; }
        public virtual PatientModel Patient { get; set; }
    }
}
