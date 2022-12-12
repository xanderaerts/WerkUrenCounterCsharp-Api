using System;
using WerkurenCounterCsharp_api.Models;
namespace WerkurenCounterCsharp_api.Repositories
{
    public interface IRepo
    {
        IEnumerable<WorkDay> getAllWorkDay();

        WorkDay getWorkdayById(int id);
        
    }
}
