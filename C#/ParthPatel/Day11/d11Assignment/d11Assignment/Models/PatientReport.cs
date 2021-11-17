using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d11Assignment
{
    class PatientReport
    {
        public int PatientReportID { get; set; }

        public int BloodPressure{ get; set; }

        public int Sugar { get; set; }

        public int Heartbit { get; set; }

        public int HealthStatus { get; set; }

        public virtual Patient PatientID { get; set; }


    }
}
