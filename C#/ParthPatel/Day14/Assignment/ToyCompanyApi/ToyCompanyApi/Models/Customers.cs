using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ToyCompanyApi.Models
{
    public partial class Customers
    {
        public Customers()
        {
            OrderHeaders = new HashSet<OrderHeaders>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(32)]
        public string Name { get; set; }

        [Required]
        [MaxLength(10)]
        public string ContactNumber { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual ICollection<OrderHeaders> OrderHeaders { get; set; }
    }
}
