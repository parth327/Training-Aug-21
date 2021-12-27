using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalManagement.Entities
{
    public partial class Doctor
    {
        public Doctor()
        {
            Appointment = new HashSet<Appointment>();
            Patient = new HashSet<Patient>();
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

        public virtual Department Department { get; set; }
        public virtual ICollection<Appointment> Appointment { get; set; }
        public virtual ICollection<Patient> Patient { get; set; }
    }
}
