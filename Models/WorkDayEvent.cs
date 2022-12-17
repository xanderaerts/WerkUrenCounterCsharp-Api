using System;

namespace WerkurenCounterCsharp_api.Models
{
       public enum WorkDayEventAction { 
        StartDay = 1,
        WorkToRest,
        RestToWork,
        EndDay
    }
     public class WorkDayEvent
    {
        public int id{get;set;}

        public DateTime StartEvent { get; set; }

        public WorkDayEventAction Action { get; set; }


    }
}
