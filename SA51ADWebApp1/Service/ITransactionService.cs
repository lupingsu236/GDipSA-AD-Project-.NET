using Microsoft.AspNetCore.Http;
using SA51ADWebApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Service
{
    public interface ITransactionService
    {
        public void saveTransaction(StationOnLine sol, int userId);
        public List<Transaction> getAllBreakdownsIn6Months();
        public List<Transaction> getAllTransactionsAtStation(StationOnLine sol);
    }
}
