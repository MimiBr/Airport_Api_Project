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
        public  async Task<ActionResult<Flight>> Get()
        {
            var list =  await _flightService.GettAllAsync();
            var newList = _mapper.Map<IEnumerable<FlightDto>>(list);
            return Ok(newList);
        }

        // GET api/<FlightsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Passenger>> Get(int id)
        {
            
            var flight =await _flightService.GetByIdAsync(id);
            var newFlight=_mapper.Map<FlightDto>(flight);
          return Ok(newFlight);
        }

        // POST api/<FlightsController>
        [HttpPost]
        public async Task Post([FromBody] FlightDto f)
        {
           
           var  flightToAdd=_mapper.Map<Flight>(f);
          await  _flightService.PostNewFlightAsync(flightToAdd);
        }

        // PUT api/<FlightsController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] FlightDto f)
        {
            
            var flightToAdd = _mapper.Map<Flight>(f);

         await _flightService.PutFlightAsync(id, flightToAdd);

        }

        // DELETE api/<FlightsController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
          
          await _flightService.DeleteFlightAsync(id);
        }
    }
}
