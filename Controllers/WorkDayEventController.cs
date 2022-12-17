using System;
using Microsoft.AspNetCore.Mvc;
using WerkurenCounterCsharp_api.Models;
using WerkurenCounterCsharp_api.Repositories;
using WerkurenCounterCsharp_api.DTO;
using AutoMapper;


namespace WerkurenCounterCsharp_api.Controllers
{
    [ApiController]
    [Route("api/WorkDayEvents")]
    public class WorkDayEventController: ControllerBase
    {
        List<WorkDayEvent> WorkDayEventList = new List<WorkDayEvent> ();

        private readonly IRepo _repo;
        private readonly IMapper _map;

        public WorkDayEventController(IRepo repo,IMapper map){
           // this.WorkDayEventList.Add(new WorkDayEvent(){id=1,Name="Xander",StartEvent=new DateTime(),EndEvent=new DateTime(),Action=WorkDayEventAction.StartDay});

            this._repo = repo;
            this._map = map;

        }

        [HttpGet]
        public ActionResult getAll(){
            return Ok(_map.Map<IEnumerable<WorkDayEventDto>>(this._repo.getAllWorkDayEvent()));
        } 

        [HttpGet("{id}",Name="getById")]
        public ActionResult getById(int id){
            return Ok(_map.Map<WorkDayEventDto>(this._repo.getWorkDayEventById(id)));
        }

        [HttpPost]
        public ActionResult add(WorkDayEvent wde){
            var Wde = _map.Map<WorkDayEvent>(wde);
            _repo.addWorkDayEvent(wde);

            _repo.SaveDbChanges();

            return CreatedAtRoute(nameof(getById),new {id = Wde.id}, Wde);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id,WorkDayEventDto dto){
            var checkWde = _repo.getWorkDayEventById(id);
            if(checkWde == null){
                return NotFound();
            }

            _map.Map(dto,checkWde);

            _repo.updateWorkDayEvent(checkWde);
            _repo.SaveDbChanges();

            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id){
            var checkWde = _repo.getWorkDayEventById(id);
            if(checkWde == null){
                return NotFound();
            }

            _repo.deleteWorkDayEvent(checkWde);
            _repo.SaveDbChanges();
            return Ok();
        }

        [HttpGet("latest")]
        public ActionResult getLatest(){
            return Ok(_map.Map<WorkDayEventDto>(this._repo.getLatest()));

        }

    }
}

