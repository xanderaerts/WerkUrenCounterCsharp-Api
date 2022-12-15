using System;
using WerkurenCounterCsharp_api.Models;

namespace WerkurenCounterCsharp_api.DTO
{
    public class WorkDayEventDto
    {
        
        public String? Name { get; set; }

        public DateTime StartEvent { get; set; }
        public DateTime EndEvent { get; set; }

        public WorkDayEventAction Action { get; set; }

    }
}
