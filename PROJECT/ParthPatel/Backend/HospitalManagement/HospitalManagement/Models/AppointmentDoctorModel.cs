using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalManagement.Models
{
    public partial class AppointmentDoctorModel
    {
        public Guid AppointmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AppointmentDate { get; set; }
        public string TimeSelection { get; set; }
        public string DoctorName { get; set; }
        public string AvailableTo { get; set; }
        public string AvailableFrom { get; set; }
        public bool? IsDelete { get; set; }
    }
}
