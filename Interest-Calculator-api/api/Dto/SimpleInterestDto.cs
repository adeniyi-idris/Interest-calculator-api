using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dto
{
    public class SimpleInterestDto
    {
        public decimal Principal {get; set;}// amount of money
        public double Rate {get; set;}// interest rate in percentage
        public int Time {get; set;}// time in years
    }
}