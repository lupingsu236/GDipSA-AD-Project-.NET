using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Models
{
    public class Transaction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        public virtual Admin User { get; set; }

        [Required]
        public int StationOnLineId { get; set; }

        public virtual StationOnLine StationOnLine { get; set; }

        [Required]
        public Status newStatusOfStation { get; set; }

        [Required]
        public DateTime transactionTime { get; set; }

        public string notes { get; set; }
    }
}
