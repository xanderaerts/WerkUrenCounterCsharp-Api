using System;
using AutoMapper;
using WerkurenCounterCsharp_api.DTO;
using WerkurenCounterCsharp_api.Models;

namespace WerkurenCounterCsharp_api.Mappings
{
    public class WorkDayProfile: Profile  
    {
        public WorkDayProfile(){
            CreateMap<WorkDay,WorkDayDto>();
        }
        
    }
}
