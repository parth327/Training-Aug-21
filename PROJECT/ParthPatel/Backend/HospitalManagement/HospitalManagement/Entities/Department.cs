using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalManagement.Entities
{
    public partial class Department
    {
        public Department()
        {
            Doctor = new HashSet<Doctor>();
            Nurse = new HashSet<Nurse>();
        }

        public Guid DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? OnCreated { get; set; }
        public DateTime? OnUpdated { get; set; }

        public virtual ICollection<Doctor> Doctor { get; set; }
        public virtual ICollection<Nurse> Nurse { get; set; }
    }
}
