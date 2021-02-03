using SA51ADWebApp1.Models;
using SA51ADWebApp1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Service
{
    public class AdminService : IAdminService
    {
        protected Database dbcontext;
        public AdminService(Database dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public Boolean validateUser(String username, String password)
        {
            Admin inDatabase = dbcontext.Admins.Where(x => x.username == username && x.password == password).FirstOrDefault();
            if (inDatabase == null) { return false; }
            else { return true; }
        }
    }
}
