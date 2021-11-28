using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToyCompanyApi.Models
{
    public partial class ShippingAddresses
    {
        [Key]
        public int Id { get; set; }
        public int OrderHeaderId { get; set; }
        public int AddressId { get; set; }

        public virtual Addresses Address { get; set; }
        public virtual OrderHeaders OrderHeader { get; set; }

    }
}
