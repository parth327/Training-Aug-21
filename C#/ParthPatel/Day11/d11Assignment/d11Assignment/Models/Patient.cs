using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d11Assignment
{
    class Patient
    {
        public int PatientID { get; set; }

        public string PatientName { get; set; }

        public virtual Assistent AssistentID { get; set; }

    }
}
