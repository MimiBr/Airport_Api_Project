using Airport.Core.DTOs;
using Airport.Core.Services;
using Airport.Service;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IflightService _flightService;
        public FlightsController(IflightService flightService, IMapper mapper)
        {
            _flightService = flightService;
            _mapper = mapper;
        }

        // GET: api/<FlightsController>
        [HttpGet]
        public ActionResult<Flight> Get()
        {
            var list = _flightService.GettAll();
            var newList = _mapper.Map<IEnumerable<FlightDto>>(list);
            return Ok(newList);
        }

        // GET api/<FlightsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            
            var flight = _flightService.GetById(id);
            var newFlight=_mapper.Map<FlightDto>(flight);
          return Ok(newFlight);
        }

        // POST api/<FlightsController>
        [HttpPost]
        public void Post([FromBody] FlightDto f)
        {
           
           var  flightToAdd=_mapper.Map<Flight>(f);
            _flightService.PostNewFlightAsync(flightToAdd);
        }

        // PUT api/<FlightsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] FlightDto f)
        {
            
            var flightToAdd = _mapper.Map<Flight>(f);

            _flightService.PutFlight(id, flightToAdd);

        }

        // DELETE api/<FlightsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
          
           _flightService.DeleteFlight(id);
        }
    }
}
