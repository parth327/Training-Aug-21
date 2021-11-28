using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace ToyCompanyApi.Models
{
    public partial class Addresses
    {
        public Addresses()
        {
            ManufacturingPlants = new HashSet<ManufacturingPlants>();
            ShippingAddresses = new HashSet<ShippingAddresses>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(32)]
        public string City { get; set; }
        [Required]
        [MaxLength(32)]
        public string State { get; set; }

        public virtual ICollection<ManufacturingPlants> ManufacturingPlants { get; set; }
        public virtual ICollection<ShippingAddresses> ShippingAddresses { get; set; }
    }
}
