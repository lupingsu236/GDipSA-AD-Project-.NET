using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Models
{
    public class Station
    {
        public string Id { get; set; }

        [Required]
        public string stationName { get; set; }

        public virtual ICollection<StationOnLine> StationOnLines { get; set; }
    }
}
