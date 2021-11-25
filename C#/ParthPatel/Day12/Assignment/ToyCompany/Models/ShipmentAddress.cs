using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Day14Api.Models
{
    class ShipmentAddress
    {
        [Key]
        public int Id { get; set; }
        public int OrderHeaderId { get; set; }
        public int AddressId { get; set; }

        public Address Address { get; set; }
        public OrderHeader OrderHeader { get; set; }

    }
}
