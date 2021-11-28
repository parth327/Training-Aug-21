using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToyCompanyApi.Models
{
    public partial class OrderDetails
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ToyId { get; set; }
        public int Quantity { get; set; }

        public virtual OrderHeaders Order { get; set; }
        public virtual Toys Toy { get; set; }
    }
}
