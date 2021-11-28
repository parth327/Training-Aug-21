using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDataApi.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        [MaxLength(50, ErrorMessage = "Name can only contain 50 characters")]
        public string Name { get; set; }
    }
}
