using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SA51ADWebApp1.Models;
using SA51ADWebApp1.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Controllers
{
    [Route("api")]
    [ApiController]
    public class APIController : ControllerBase
    {
        private readonly Database context;

        public APIController(Database context)
        {
            this.context = context;
        }

        [Route("NonOperationalStations")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StationOnLineJson>>> GetNonOperationalStationsOnLines()
        {
            return await context.StationOnLines.Where(x => x.status != Status.Operational).
                Select(x => new StationOnLineJson
                {
                    StationCode = x.stationCode,
                    StationName = x.Station.stationName,
                    TimeToNextStation = x.editedTimeToNextStation,
                    TimeToNextStationOpp = x.editedTimeToNextStationOpp,
                    Status = x.status
                })
                .ToListAsync();
        }

        [Route("News")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewsJson>>> GetLatestNews()
        {
            return await context.Transactions.OrderByDescending(x => x.transactionTime).Take(10).Select(x => new NewsJson
            {
                Time = x.transactionTime.ToString(),
                StationCode = x.StationOnLine.stationCode,
                StationName = x.StationOnLine.Station.stationName,
                CurrentStatus = x.newStatusOfStation,
                TimeToNextStation = x.editedTimeToNextStation,
                TimeToNextStationOpp = x.editedTimeToNextStationOpp
            }).ToListAsync();
        }
    }
}
