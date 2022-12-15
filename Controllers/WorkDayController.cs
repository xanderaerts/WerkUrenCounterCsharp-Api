using System;
using Microsoft.AspNetCore.Mvc;
using WerkurenCounterCsharp_api.Models;
using WerkurenCounterCsharp_api.Repositories;
using WerkurenCounterCsharp_api.DTO;
using AutoMapper;


namespace WerkurenCounterCsharp_api.Controllers
{
    [ApiController]
    [Route("api/workdays")]
    public class WorkDayController: ControllerBase
    {
        List<WorkDay> workDayList = new List<WorkDay> ();

        private readonly IRepo _repo;
        private readonly IMapper _map;

        public WorkDayController(IRepo repo,IMapper map){
           // this.workDayList.Add(new WorkDay(){id=1,Name="Xander",StartEvent=new DateTime(),EndEvent=new DateTime(),Action=WorkDayAction.StartDay});

            this._repo = repo;
            this._map = map;

        }

        [HttpGet]
        public ActionResult getAll(){
            return Ok(_map.Map<IEnumerable<WorkDayDto>>(this._repo.getAllWorkDay()));
        } 

        [HttpGet("{id}")]
        public ActionResult getById(int id){
            return Ok(_map.Map<WorkDayDto>(this._repo.getWorkdayById(id)));
        }
        
    }
}

