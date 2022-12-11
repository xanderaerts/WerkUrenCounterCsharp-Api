using System;
using Microsoft.AspNetCore.Mvc;
using WerkurenCounterCsharp_api.Models;

namespace WerkurenCounterCsharp_api.Controllers
{
    [ApiController]
    [Route("api/workdays")]
    public class WorkDayController: ControllerBase
    {
        List<WorkDay> workDayList = new List<WorkDay> ();

        public WorkDayController(){
            this.workDayList.Add(new WorkDay(){id=1,Name="Xander",StartEvent=new DateTime(),EndEvent=new DateTime(),Action=WorkDayAction.StartDay});

        }

        [HttpGet]
        public ActionResult getAll(){
            return Ok("<h1>yoooo</h1>");
        } 

        [HttpGet("{id}")]
        public ActionResult getById(int id){
            var wd = this.workDayList.FirstOrDefault<WorkDay>(t => t.id == id); 
            return Ok();
        }
        
    }
}

