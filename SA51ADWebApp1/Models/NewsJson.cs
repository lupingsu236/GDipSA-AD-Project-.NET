using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Models
{
    public class NewsJson
    {
        public string Time { get; set; }
        public string StationCode { get; set; }
        public string StationName { get; set; }
        public Status CurrentStatus { get; set; }
        public int TimeToNextStation { get; set; }
        public int TimeToNextStationOpp { get; set; }
    }
}
