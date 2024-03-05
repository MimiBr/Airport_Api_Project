using Airport.Core.DTOs;
using Airport.Core.Services;
using Airport.Service;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PilotsController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly IpilotService _pilotService;
        public PilotsController(IpilotService pilotsService, IMapper mapper)
        {
            _mapper = mapper;
            _pilotService = pilotsService;
        }
        // GET: api/<PilotController>
        [HttpGet]
        public ActionResult<Pilot> Get()
        {
            var listPilot = _pilotService.GettAll();
            var newlistPilo = _mapper.Map<IEnumerable<PilotDto>>(listPilot);

            return Ok(newlistPilo);
        }

        // GET api/<PilotController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var pilot = _pilotService.GetById(id);
            var newPilot=_mapper.Map<PilotDto>(pilot);     
            return Ok(newPilot);
        }

        // POST api/<PilotController>
        [HttpPost]
        public void Post([FromBody] PilotDto p)
        {
      
         var pilotToAdd=_mapper.Map<Pilot>(p);
         _pilotService.PostNewPilot(pilotToAdd);
        }

        // PUT api/<PilotController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PilotDto p)
        {
           
            var pilotToAdd = _mapper.Map<Pilot>(p);

            _pilotService.PutPilot(id, pilotToAdd);
        }

        // DELETE api/<PilotController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
            _pilotService.DeletePilot(id);

        }
    }
}
