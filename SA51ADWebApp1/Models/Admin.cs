using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;

namespace SA51ADWebApp1.Models
{
    public class Admin
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set;  }

        [Required]
        public byte[] salt { get; set; }

        public void setPasswordAndSalt(string password)
        {
            byte[] newsalt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(newsalt);
            }
            this.salt = newsalt;
            string hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            this.password = hashedPassword;
        }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
