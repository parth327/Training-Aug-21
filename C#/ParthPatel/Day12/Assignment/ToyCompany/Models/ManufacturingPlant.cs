using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Day14Api.Models
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
