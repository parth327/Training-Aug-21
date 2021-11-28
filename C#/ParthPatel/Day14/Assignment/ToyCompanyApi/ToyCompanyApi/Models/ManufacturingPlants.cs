using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToyCompanyApi.Models
{
    public partial class ManufacturingPlants
    {
        public ManufacturingPlants()
        {
            ToyProductions = new HashSet<ToyProductions>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public int AddressId { get; set; }

        public virtual Addresses Address { get; set; }
        public virtual ICollection<ToyProductions> ToyProductions { get; set; }
    }
}
