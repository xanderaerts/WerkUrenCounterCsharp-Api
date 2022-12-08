using System;

namespace WerkurenCounterCsharp_api.Models
{
       public enum WorkDayAction { 
        StartDay = 1,
        WorkToRest,
        RestToWork,
        EndDay
    }
     public class WorkDay
    {
        public int id{get;set;}
        public String Name { get; set; }

        public DateTime StartEvent { get; set; }
        public DateTime EndEvent { get; set; }

        public WorkDayAction Action { get; set; }


    }
}
