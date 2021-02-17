using SA51ADWebApp1.Models;
using SA51ADWebApp1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SA51ADWebApp1.Service
{
    public class StationOnLineService : IStationOnLineService
    {
        protected Database dbcontext;
        public StationOnLineService(Database dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public List<StationOnLine> getAllNonOperational()
        {
            List<StationOnLine> nonOperationalLines = dbcontext.StationOnLines.Where(x => (int)x.status != 0).ToList();
            return nonOperationalLines;
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

        public void saveEdit(StationOnLine sol)
        {
            dbcontext.Update(sol);
            dbcontext.SaveChanges();
        }

        public string getSpecificStationName(String stationCode)
        {
            StationOnLine specificStation = dbcontext.StationOnLines.Where(x => x.stationCode == stationCode).FirstOrDefault();
            List<Station> stationall = dbcontext.Stations.Where(x => x.StationOnLines.Contains(specificStation)).ToList();
            return stationall.FirstOrDefault().stationName;
        }

        public string GetSpecificStationLine(string stationCode)
        {
            return dbcontext.StationOnLines.Where(x => x.stationCode == stationCode).Select(x => x.Line.lineName).FirstOrDefault();
        }

        public List<string> GenerateNotificationMsg(StationOnLine stationOnLine)
        {
            List<string> stationsOnLineNames = dbcontext.StationOnLines.Where(x => x.LineId == stationOnLine.LineId).OrderBy(x => x.stationCode).Select(x => x.Station.stationName).ToList();
            string firstStationOnLine = stationsOnLineNames[0];
            string lastStationOnLine = stationsOnLineNames[stationsOnLineNames.Count() - 1];
            string stationName = getSpecificStationName(stationOnLine.stationCode);

            string title = $"{GetSpecificStationLine(stationOnLine.stationCode)}: ";
            string msg;

            if (stationOnLine.status == Status.BreakdownBoth)
            {
                title += "BREAKDOWN";
                msg = $"Train services from {stationOnLine.stationCode} {stationName} have stopped.";
            }
            else if (stationOnLine.status == Status.BreakdownOpposite)
            {
                title += "BREAKDOWN";
                msg = $"Train services from {stationOnLine.stationCode} {stationName} in the direction of {firstStationOnLine} have stopped.";
            }
            else if (stationOnLine.status == Status.BreakdownForward)
            {
                title += "BREAKDOWN";
                msg = $"Train services from {stationOnLine.stationCode} {stationName} in the direction of {lastStationOnLine} have stopped.";
            }
            else if (stationOnLine.status == Status.DelayBoth)
            {
                title += "DELAY";
                msg = $"Train services from {stationOnLine.stationCode} {stationName} have been delayed.";
            }
            else if (stationOnLine.status == Status.DelayOpposite)
            {
                title += "DELAY";
                msg = $"Train services from {stationOnLine.stationCode} {stationName} in the direction of {firstStationOnLine} have been delayed.";
            }
            else if (stationOnLine.status == Status.DelayForward)
            {
                title += "DELAY";
                msg = $"Train services from {stationOnLine.stationCode} {stationName} in the direction of {lastStationOnLine} have been delayed.";
            }
            else
            {
                title += "NORMAL";
                msg = $"Train services from {stationOnLine.stationCode} {stationName} are now running normally.";
            }

            List<string> output = new List<string>
            {
                title,
                msg
            };
            return output;
        }
    }
}
