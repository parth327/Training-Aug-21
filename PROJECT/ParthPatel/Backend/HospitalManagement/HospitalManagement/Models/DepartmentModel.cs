using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalManagement.Models
{
    public partial class DepartmentModel
    {
        public DepartmentModel()
        {
            Doctor = new HashSet<DoctorModel>();
            Nurse = new HashSet<NurseModel>();
        }

        public Guid DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? OnCreated { get; set; }
        public DateTime? OnUpdated { get; set; }

        public virtual ICollection<DoctorModel> Doctor { get; set; }
        public virtual ICollection<NurseModel> Nurse { get; set; }
    }
}
