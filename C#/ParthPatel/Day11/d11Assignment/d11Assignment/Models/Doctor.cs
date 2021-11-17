using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d11Assignment
{
    class Doctor
    {
        public int DoctorID { get; set; }

        public int DoctorName { get; set; }

        public virtual Department DepartmentID { get; set; }
    }
}
