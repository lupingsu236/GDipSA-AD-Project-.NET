using SA51ADWebApp1.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Models
{
    public class StationOnLine
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string stationCode { get; set; }
        
        [Required]
        public int StationId { get; set; }

        public virtual Station Station { get; set; }

        [Required]
        public int LineId { get; set; }

        public virtual Line Line { get; set; }

        [Required]
        public Status status { get; set; }

        [Required]
        public int timeToNextStation { get; set; }

        [Required]
        public int timeToNextStationOpp { get; set; }

        [isPositive]
        public int editedTimeToNextStation { get; set; }

        [isPositive]
        public int editedTimeToNextStationOpp { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
