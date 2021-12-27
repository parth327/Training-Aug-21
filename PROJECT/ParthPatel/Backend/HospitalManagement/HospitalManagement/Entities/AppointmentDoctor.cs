using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalManagement.Entities
{
    public partial class AppointmentDoctor
    {
        public Guid AppointmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public DateTime? TimeSelection { get; set; }
        public string DoctorName { get; set; }
        public DateTime? AvailableTo { get; set; }
        public DateTime? AvailableFrom { get; set; }
        public bool? IsDelete { get; set; }
    }
}
