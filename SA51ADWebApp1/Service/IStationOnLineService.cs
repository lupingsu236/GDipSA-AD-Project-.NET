using SA51ADWebApp1.Models;
using System;
using System.Collections.Generic;

namespace SA51ADWebApp1.Service
{
    public interface IStationOnLineService
    {
        public void saveEdit(StationOnLine sol);
        public List<StationOnLine> getAllStationsOnLine(String Line);
        public StationOnLine getSpecificStationOnLine(String stationCode);
        public List<StationOnLine> getAllNonOperational();
        public string getSpecificStationName(string stationCode);
        public string GetSpecificStationLine(string stationCode);
        public List<string> GenerateNotificationMsg(StationOnLine stationOnLine);
    }
}
