using Microsoft.AspNetCore.Http;
using SA51ADWebApp1.Models;
using SA51ADWebApp1.Repository;
using System;

namespace SA51ADWebApp1.Service
{
    public class TransactionService : ITransactionService
    {
        protected Database dbcontext;
        public TransactionService(Database dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public void saveTransaction(StationOnLine sol, int userId)
        {
            Transaction newTransaction = new Transaction();
            newTransaction.UserId = userId;
            newTransaction.StationOnLineId = sol.Id;
            newTransaction.newStatusOfStation = sol.status;
            newTransaction.transactionTime = DateTime.Now;
            dbcontext.Add(newTransaction);
            dbcontext.SaveChanges();
        }
    }
}
