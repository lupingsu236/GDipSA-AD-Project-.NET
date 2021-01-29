using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Models
{
    public class StationOnLine
    {
        public string Id { get; set; }

        [Required]
        public string stationCode { get; set; }
        
        [Required]
        public string StationId { get; set; }

        public virtual Station Station { get; set; }

        [Required]
        public string LineId { get; set; }

        public virtual Line Line { get; set; }

        [Required]
        public string status { get; set; }

        [Required]
        public int timeToNextStation { get; set; }

        [Required]
        public int timeToNextStationOpp { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
