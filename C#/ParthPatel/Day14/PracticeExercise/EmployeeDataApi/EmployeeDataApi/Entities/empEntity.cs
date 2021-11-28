using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDataApi.Entities
{
    public class EmpEntity
    {   
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name can only contain 50 characters")]
        public string Name { get; set; }

    }
}
