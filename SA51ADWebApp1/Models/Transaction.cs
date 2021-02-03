using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Models
{
    public class Transaction
    {
        public string Id { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual Admin User { get; set; }

        [Required]
        public string StationOnLineId { get; set; }

        public virtual StationOnLine StationOnLine { get; set; }

        [Required]
        public string newStatusOfStation { get; set; }

        [Required]
        public string direction { get; set; }

        [Required]
        public DateTime transactionTime { get; set; }

        [Required]
        public string notes { get; set; }
    }
}
