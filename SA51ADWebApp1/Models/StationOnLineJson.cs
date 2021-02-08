using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Models
{
    public class StationOnLineJson
    {
        public string stationCode { get; set; }

        public string stationName { get; set; }

        public int timeToNextStation { get; set; }

        public int timeToNextStationOpp { get; set; }
    }
}

