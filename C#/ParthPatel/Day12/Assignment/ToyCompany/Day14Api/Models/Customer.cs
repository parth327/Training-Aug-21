using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Day14Api.Models
{
    class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(32)]
        public string Name { get; set; }

        [Required]
        [MaxLength(10)]
        public string ContactNumber { get; set; }

        public bool IsActive { get; set; } = true;

    }
}
