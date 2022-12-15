using System;
using Microsoft.EntityFrameworkCore;
using WerkurenCounterCsharp_api.Models;

namespace WerkurenCounterCsharp_api.Contexts
{
    public class WorkDayEventContext: DbContext
    {
        public WorkDayEventContext(DbContextOptions<WorkDayEventContext> opt):base(opt)
        {
            
        }
        public DbSet<WorkDayEvent> WorkDayEvents {get;set;}
        
    }
}
