using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Model
{
    public class Interest
    {
        public int Id {get; set;}
        public decimal Principal {get; set;}// amount of money
        public double Rate {get; set;}// interest rate in percentage
        public int Time {get; set;}// time in years
        public int CompoundFrequency {get; set;} = 1;// for compound interest
    }
}