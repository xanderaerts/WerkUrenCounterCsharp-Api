using System;
using WerkurenCounterCsharp_api.Models;
namespace WerkurenCounterCsharp_api.Repositories
{
    public interface IRepo
    {
        IEnumerable<WorkDayEvent> getAllWorkDayEvent();

        WorkDayEvent getWorkDayEventById(int id);

        void addWorkDayEvent(WorkDayEvent wde);

        void updateWorkDayEvent(WorkDayEvent wde);

        void deleteWorkDayEvent(WorkDayEvent wde);

        WorkDayEvent getLatest();

        void SaveDbChanges();
        
    }
}
