using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Day14Api.Models
{
    class ToyType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(32)]
        public string TypeName { get; set; }
    }
}
