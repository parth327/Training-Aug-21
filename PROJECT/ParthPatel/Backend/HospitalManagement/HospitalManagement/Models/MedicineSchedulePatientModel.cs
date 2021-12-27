using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalManagement.Models
{
    public partial class MedicineSchedulePatientModel
    {
        public Guid MedicineScheduleId { get; set; }
        public string PatientName { get; set; }
        public string MedicineName { get; set; }
        public bool? DayPartMorning { get; set; }
        public bool? DayPartNoon { get; set; }
        public bool? DayPartEvening { get; set; }
        public bool? IsDelete { get; set; }
    }
}
