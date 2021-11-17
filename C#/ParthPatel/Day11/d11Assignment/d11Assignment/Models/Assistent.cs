using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d11Assignment
{
    class Assistent
    {
        public int AssistentID { get; set; }

        public string AssistentName { get; set; }

        public virtual Doctor DoctorID { get; set; }

    }
}
