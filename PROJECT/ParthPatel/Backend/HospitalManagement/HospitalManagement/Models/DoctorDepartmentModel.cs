using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
//#nullable disable

namespace HospitalManagement.Models
{
    public partial class DoctorDepartmentModel
    {
        public Guid DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string AvailableTo { get; set; }
        public string AvailableFrom { get; set; }
        public string DepartmentName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
    }
}
