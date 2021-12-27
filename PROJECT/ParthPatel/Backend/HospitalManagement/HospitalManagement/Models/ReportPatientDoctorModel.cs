using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalManagement.Models
{
    public partial class ReportPatientDoctorModel
    {
        public Guid ReportId { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public int? BloodPressure { get; set; }
        public int? Sugar { get; set; }
        public int? HeartBeat { get; set; }
        public string Description { get; set; }
        public bool? IsDelete { get; set; }
    }
}
