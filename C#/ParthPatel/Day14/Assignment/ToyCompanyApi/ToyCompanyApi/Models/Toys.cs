using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToyCompanyApi.Models
{
    public partial class Toys
    {
        public Toys()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(32)]
        public string ToyName { get; set; }
        [Required]
        [MaxLength(10)]
        public decimal Price { get; set; }
        [Required]
        public int TypeId { get; set; }

        public virtual ToyTypes Type { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
