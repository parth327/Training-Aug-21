using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d11Assignment
{
    class PatinetMedicineList
    {
        public int ListID { get; set; }

        public int Daypart { get; set; }

        public virtual Patient PatientID { get; set; }

        public virtual Medicine MedicineID { get; set; }

    }
}
