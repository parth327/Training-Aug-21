using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToyCompanyApi.Models
{
    public partial class ToyTypes
    {
        public ToyTypes()
        {
            ToyProductions = new HashSet<ToyProductions>();
            Toys = new HashSet<Toys>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(32)]
        public string TypeName { get; set; }

        public virtual ICollection<ToyProductions> ToyProductions { get; set; }
        public virtual ICollection<Toys> Toys { get; set; }
    }
}
