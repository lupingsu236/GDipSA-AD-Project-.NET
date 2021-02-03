using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Models
{
    public enum Status
    {
        Operational, 
        BreakdownBoth,
        BreakdownForward,
        BreakdownOpposite,
        DelayBoth,
        DelayForward,
        DelayOpposite
    }
}
