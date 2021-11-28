using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToyCompanyApi.Models
{
    public partial class ToyProductions
    {
        [Key]
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int ManufacturingPlantId { get; set; }

        public virtual ManufacturingPlants ManufacturingPlant { get; set; }
        public virtual ToyTypes Type { get; set; }
    }
}
