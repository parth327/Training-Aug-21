using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDataApi.Entities
{
    public class CourseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        public Guid EmployeeId { get; set; }

    }
}
