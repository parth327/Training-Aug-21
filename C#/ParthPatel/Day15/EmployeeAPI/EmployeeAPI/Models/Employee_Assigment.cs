using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Models
{
    public class Employee_Assigment
    {
        [Key]
        public Int64 Id { get; set; }
        public Int64 EmployeeId { get; set; }
        public Int64 AssignmentId { get; set; }
        public Assignment Assignment { get; set; }
        public Employee Employee { get; set; }
    }
}
