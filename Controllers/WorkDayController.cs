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

        [HttpGet]
        public ActionResult getAll(){
            return Ok("<h1>yoooo</h1>");
        } 

        [HttpGet("{id}")]
        public ActionResult getById(int id){
            WorkDay wd = this.workDayList.FirstOrDefault<WorkDay>(t => t.id == id); 
            return Ok();
        }
        
    }
}

