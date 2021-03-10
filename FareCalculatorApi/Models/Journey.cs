using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FareCalculatorApi.Models
{
    public class Journey
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        public int FromZone { get; set; }

        public int ToZone { get; set; }

        public DateTime StartDateTime { get; set; }
    }
}
