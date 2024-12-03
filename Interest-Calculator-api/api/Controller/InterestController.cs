using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dto;
using Microsoft.AspNetCore.Mvc;

namespace api.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class InterestController : ControllerBase
    {
        private readonly Imapper _mapper;

        public InterestController(Imapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost("simple-interest")]
        public IActionResult CalculateSimpleInterest([FromBody]SimpleInterestDto SI)
        {
            if(SI.Principal <= 0 || SI.Rate <= 0 || SI.Time <= 0)
            {
                return BadRequest("Input Field");
            }
            var SIModel = _mapper.Map<Interest>(SI);

            var simpleInterest = (SIModel.Principal * (decimal)SIModel.Rate * SIModel.Time)/100;

            return Ok(simpleInterest);
        }

        [HttpPost("compound-interest")]
        public IActionResult CalculateCompoundInterest([FromBody]CompoundInterestDto CI)
        {
            if(CI.Principal <= 0 || CI.Rate <= 0 || CI.Time <= 0)
            {
                return BadRequest("Input Field");
            }

            var CIModel = _mapper.Map<Interest>(CI);

            double ratePerPeriod = CIModel.Rate / (100 * CIModel.CompoundFrequency);
            double totalPeriods = CIModel.CompoundFrequency * CIModel.Time;

            decimal coumpoundAmount = CIModel.Principal * (decimal)Math.Pow(1 + ratePerPeriod, totalPeriods);
            decimal compoundInterest = coumpoundAmount - CIModel.Principal;

            return Ok(compoundInterest);

            /*
            return Ok(new
            {
                Principal = CIModel.Principal,
                Rate = CIModel.Rate,
                Time = CIModel.Time,
                CompoundingFrequency = CIModel.CompoundingFrequency,
                CompoundInterest = compoundInterest
            })
            */
        }
    }
}