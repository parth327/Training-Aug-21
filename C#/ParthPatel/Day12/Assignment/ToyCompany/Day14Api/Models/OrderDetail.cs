﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Day14Api.Models
{
    class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        public int OrderID { get; set; }
        public int ToyId { get; set; }
        public int Quantity { get; set; }

        public Toy Toy { get; set; }
        public OrderHeader Order { get; set; }

    }
}
