using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Models
{
    public class User
    {

        public string Id { get; set; }

        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
