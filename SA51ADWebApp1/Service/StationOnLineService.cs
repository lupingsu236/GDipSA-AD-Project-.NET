using SA51ADWebApp1.Models;
using SA51ADWebApp1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Service
{
    public class StationOnLineService : IStationOnLineService
    {
        protected Database dbcontext;
        public StationOnLineService(Database dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public List<StationOnLine> getAllStationsOnLine(string Line)
        {
            List<StationOnLine> listAll = dbcontext.StationOnLines.Where(x => x.Line.lineName == Line).OrderBy(x => x.stationCode).ToList();
            return listAll;
        }
        public StationOnLine getSpecificStationOnLine(string stationCode)
        {
            StationOnLine specificStation = dbcontext.StationOnLines.Where(x => x.stationCode == stationCode).FirstOrDefault();
            return specificStation;
        }
    }
}
