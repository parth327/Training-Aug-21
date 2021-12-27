using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalManagement.Models
{
    public partial class MedicineModel
    {
        public MedicineModel()
        {
            MedicineSchedule = new HashSet<MedicineScheduleModel>();
        }

        public Guid MedicineId { get; set; }
        public string MedicineName { get; set; }
        public string CompanyName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? OnCreated { get; set; }
        public DateTime? OnUpdated { get; set; }

        public virtual ICollection<MedicineScheduleModel> MedicineSchedule { get; set; }
    }
}
