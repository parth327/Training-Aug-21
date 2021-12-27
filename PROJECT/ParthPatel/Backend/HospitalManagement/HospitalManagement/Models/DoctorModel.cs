using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
//#nullable disable

namespace HospitalManagement.Models
{
    public partial class DoctorModel
    {
        public DoctorModel()
        {
            Appointment = new HashSet<AppointmentModel>();
            Patient = new HashSet<PatientModel>();
        }

        public Guid DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Speciality { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public DateTime? AvailableFrom { get; set; }
        public DateTime? AvailableTo { get; set; }
        public Guid? DepartmentId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? OnCreated { get; set; }
        public DateTime? OnUpdated { get; set; }

        public virtual DepartmentModel Department { get; set; }
        public virtual ICollection<AppointmentModel> Appointment { get; set; }
        public virtual ICollection<PatientModel> Patient { get; set; }
    }
}
