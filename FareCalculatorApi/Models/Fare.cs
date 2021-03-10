using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FareCalculatorApi.Models
{
    public class Fare
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        public int FromZone { get; set; }

        public int ToZone { get; set; }

        public int DefaultFare { get; set; }

        public int PeakFare { get; set; }

        public int DailyCap { get; set; }

        public int WeeklyCap { get; set; }
    }
}
