﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalTask.Assignment.Models
{
    public partial class Department
    {
        public Department()
        {
            Doctor = new HashSet<Doctor>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Doctor> Doctor { get; set; }
    }
}
