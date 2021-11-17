using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d11Assignment
{
    class DoctorPatient
    {
        public int DoctorPatientID { get; set; }

        public int Daypart { get; set; }

        public virtual Doctor DoctorID { get; set; }

        public virtual Patient PatientID { get; set; }
    }
}
