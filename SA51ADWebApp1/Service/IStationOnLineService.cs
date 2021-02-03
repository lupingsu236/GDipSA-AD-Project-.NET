﻿using SA51ADWebApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Service
{
    public interface IStationOnLineService
    {
        public List<StationOnLine> getAllStationsOnLine(String Line);
    }
}
