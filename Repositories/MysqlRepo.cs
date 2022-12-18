using System;
using WerkurenCounterCsharp_api.Models;
using WerkurenCounterCsharp_api.Contexts;

namespace WerkurenCounterCsharp_api.Repositories
{
    public class MysqlRepo : IRepo
    {
        private readonly WorkDayEventContext _context;

        public MysqlRepo(WorkDayEventContext context){
            this._context = context;
        }
           
        public IEnumerable<WorkDayEvent> getAllWorkDayEvent()
        {
            return _context.WorkDayEvents;
        
        }
        public WorkDayEvent getWorkDayEventById(int id)
        {
            return _context.WorkDayEvents.FirstOrDefault<WorkDayEvent>(t => t.id == id); 
        }

        public void addWorkDayEvent(WorkDayEvent wde){
            _context.WorkDayEvents.Add(wde);
        }

        public void updateWorkDayEvent(WorkDayEvent wde){

        }

        public void deleteWorkDayEvent(WorkDayEvent wde){
            _context.WorkDayEvents.Remove(wde);

        }

        public WorkDayEvent getLatest(){
            return _context.WorkDayEvents.OrderByDescending(x => x.id).FirstOrDefault();
           // return _context.WorkDayEvents.Last();
        }

        public void SaveDbChanges(){
            _context.SaveChanges();
        }

    }
}
