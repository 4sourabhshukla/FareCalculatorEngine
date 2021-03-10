using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FareCalculatorApi.Models
{
    public class PeakTiming
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        public string Day { get; set; }

        public ZoneType ZoneType { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }
    }

    public enum ZoneType { Inter, Intra, All };
}
