using System;
using WerkurenCounterCsharp_api.Models;

namespace WerkurenCounterCsharp_api.DTO
{
    public class WorkDayDto
    {
        
        public String? Name { get; set; }

        public DateTime StartEvent { get; set; }
        public DateTime EndEvent { get; set; }

        public WorkDayAction Action { get; set; }

    }
}
