using System;
using Microsoft.EntityFrameworkCore;
using WerkurenCounterCsharp_api.Models;

namespace WerkurenCounterCsharp_api.Contexts
{
    public class WorkDayContext: DbContext
    {
        public WorkDayContext(DbContextOptions<WorkDayContext> opt):base(opt)
        {
            
        }
        public DbSet<WorkDay> workdays {get;set;}
        
    }
}
