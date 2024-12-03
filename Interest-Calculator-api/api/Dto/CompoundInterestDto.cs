using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dto
{
    public class CompoundInterestDto
    {
        public decimal Principal {get; set;}
        public double Rate {get; set;}
        public int Time {get; set;}
        public int CompoundFrequency {get; set;} = 1;
    }
}