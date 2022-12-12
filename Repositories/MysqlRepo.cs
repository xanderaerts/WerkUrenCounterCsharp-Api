using System;
using WerkurenCounterCsharp_api.Models;
using WerkurenCounterCsharp_api.Contexts;

namespace WerkurenCounterCsharp_api.Repositories
{
    public class MysqlRepo : IRepo
    {
        private readonly WorkDayContext _context;

        public MysqlRepo(WorkDayContext context){
            this._context = context;
        }
           
        public IEnumerable<WorkDay> getAllWorkDay()
        {
            return _context.workdays;
        
        }

        public WorkDay getWorkdayById(int id)
        {
            return _context.workdays.FirstOrDefault<WorkDay>(t => t.id == id); 
        }

    }
}
