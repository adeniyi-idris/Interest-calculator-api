using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace api.Mapper
{
    public class MappingProfile: Profile
    {
       public MappingProfile()
       {
         CreateMap<SimpleInterestDto, Interest>();
         CreateMap<CompoundInterestDto, Interest>();
       }
    }
}