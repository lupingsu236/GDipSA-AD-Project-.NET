using SA51ADWebApp1.Models;
using SA51ADWebApp1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Service
{
    public interface IAdminService
    {
        public Boolean validateUser(String username, String password);
        public int getValidUserId(String username);
        public string getUserById(int id);
    }
}
