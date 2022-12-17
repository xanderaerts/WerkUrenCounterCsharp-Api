using System;
using WerkurenCounterCsharp_api.Models;

namespace WerkurenCounterCsharp_api.DTO
{
    public class WorkDayEventDto
    {
        

        public DateTime StartEvent { get; set; }

        public WorkDayEventAction Action { get; set; }

    }
}
