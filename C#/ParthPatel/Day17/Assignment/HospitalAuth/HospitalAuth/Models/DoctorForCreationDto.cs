using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAuth.Models
{
    public class DoctorForCreationDto
    {
        [Required(ErrorMessage = "FirstName is required")]
        public string DoctorName { get; set; }

        [Required(ErrorMessage = "Department Id is required")]
        public int? DepartmentId { get; set; }

    }
}
