using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToyCompanyApi.Models
{
    public partial class OrderHeaders
    {
        public OrderHeaders()
        {
            OrderDetails = new HashSet<OrderDetails>();
            ShippingAddresses = new HashSet<ShippingAddresses>();
        }
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        [MaxLength(15)]
        public decimal TotalAmount { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<ShippingAddresses> ShippingAddresses { get; set; }
    }
}
