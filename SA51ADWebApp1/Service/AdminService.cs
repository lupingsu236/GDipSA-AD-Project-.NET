using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using SA51ADWebApp1.Models;
using SA51ADWebApp1.Repository;
using System;
using System.Linq;

namespace SA51ADWebApp1.Service
{
    public class AdminService : IAdminService
    {
        protected Database dbcontext;
        public AdminService(Database dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public string getUserById(int id)
        {
            return dbcontext.Admins.Where(x => x.Id == id).FirstOrDefault().username;
        }

        public int getValidUserId(string username)
        {
            int validUserId = dbcontext.Admins.Where(x => x.username == username).FirstOrDefault().Id;
            return validUserId;
        }

        public Boolean validateUser(String username, String password)
        {
            byte[] storedSalt = dbcontext.Admins.Where(x => x.username == username).FirstOrDefault().salt;
            string hashedPassword = password;
            if (storedSalt != null)
            {
                hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: storedSalt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            }
            Admin inDatabase = dbcontext.Admins.Where(x => x.username == username && x.password == hashedPassword).FirstOrDefault();
            if (inDatabase == null) { return false; }
            else { return true; }
        }
    }
}
