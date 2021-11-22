using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Day12Assign.Models
{
    class ManufacturingPlant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AddressId { get; set; }
        public Address Address { get; set; }

    }
}
