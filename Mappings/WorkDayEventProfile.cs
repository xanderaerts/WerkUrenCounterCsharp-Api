using System;
using AutoMapper;
using WerkurenCounterCsharp_api.DTO;
using WerkurenCounterCsharp_api.Models;

namespace WerkurenCounterCsharp_api.Mappings
{
    public class WorkDayEventProfile: Profile  
    {
        public WorkDayEventProfile(){
            CreateMap<WorkDayEvent,WorkDayEventDto>();
            CreateMap<WorkDayEventDto,WorkDayEvent>();
        }
        
    }
}
