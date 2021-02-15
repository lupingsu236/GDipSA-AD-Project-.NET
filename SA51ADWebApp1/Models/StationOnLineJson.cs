using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Models
{
    public class StationOnLineJson
    {
        public string StationCode { get; set; }

        public string StationName { get; set; }

        public int TimeToNextStation { get; set; }

        public int TimeToNextStationOpp { get; set; }

        public Status Status { get; set; }
    }
}

