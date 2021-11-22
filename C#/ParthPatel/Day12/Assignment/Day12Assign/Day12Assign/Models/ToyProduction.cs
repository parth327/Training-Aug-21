﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Day12Assign.Models
{
    class ToyProduction
    {
        [Key]
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int ManufacturingPlantId { get; set; }
        public ToyType Type { get; set; }
        public ManufacturingPlant ManufacturingPlant { get; set; }

    }
}
