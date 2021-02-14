using Microsoft.AspNetCore.Http;
using SA51ADWebApp1.Models;
using SA51ADWebApp1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SA51ADWebApp1.Service
{
    public class TransactionService : ITransactionService
    {
        protected Database dbcontext;
        public TransactionService(Database dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public List<Transaction> getAllTransactionsAtStation(StationOnLine sol)
        {
            return dbcontext.Transactions.Where(x => x.StationOnLineId == sol.Id).OrderByDescending(x => x.transactionTime).ToList();
        }

        public void saveTransaction(StationOnLine sol, int userId)
        {
            Transaction newTransaction = new Transaction();
            newTransaction.UserId = userId;
            newTransaction.StationOnLineId = sol.Id;
            newTransaction.newStatusOfStation = sol.status;
            TimeZoneInfo tzf = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time");
            newTransaction.transactionTime = TimeZoneInfo.ConvertTime(DateTime.Now, tzf);
            dbcontext.Add(newTransaction);
            dbcontext.SaveChanges();
        }
    }
}
