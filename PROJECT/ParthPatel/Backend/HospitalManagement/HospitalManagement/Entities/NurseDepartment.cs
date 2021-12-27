using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalManagement.Entities
{
    public partial class NurseDepartment
    {
        public Guid NurseId { get; set; }
        public string NurseName { get; set; }
        public string DepartmentName { get; set; }
        public bool? IsDelete { get; set; }
    }
}
