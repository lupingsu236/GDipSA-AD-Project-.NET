using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Repository
{
    public class Database : DbContext
    {
        protected IConfiguration configuration;

        public Database(DbContextOptions<Database> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            // add constraints to table here
        }

        public DbSet<Models.Line> Lines { get; set; }
        public DbSet<Models.Station> Stations { get; set; }
        public DbSet<Models.StationOnLine> StationOnLines { get; set; }
        public DbSet<Models.Transaction> Transactions { get; set; }
        public DbSet<Models.User> Users { get; set; }
    }
}
