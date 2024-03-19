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
    public class PassengersController : ControllerBase
    {


        private readonly IMapper _mapper;
        private readonly IpassengerService _passengerService;
        public PassengersController(IpassengerService passengerService, IMapper mapper)
        {
            _mapper = mapper;
            _passengerService = passengerService;
        }
        // GET: api/<PassengersController>
        [HttpGet]
        public async Task<ActionResult<Passenger>> Get()
        {
            var list=await _passengerService.GettAllAsync();
            var PassengerList=_mapper.Map<IEnumerable<PassengerDto>>(list);
            return Ok(PassengerList);   
        }

        // GET api/<PassengersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
         var passenger= _passengerService.GetById(id);
            var newPassenger=_mapper.Map<PassengerDto>(passenger);
            return Ok(newPassenger);
        }

        // POST api/<PassengersController>
        [HttpPost]
        public void Post([FromBody] PassengerDto P)
        {

            var passengerToAdd = _mapper.Map<Passenger>(P);
           _passengerService.PostNewPassenger(passengerToAdd);
        }

        // PUT api/<PassengersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PassengerDto P)
        {

            var passengerToAdd = _mapper.Map<Passenger>(P);

            _passengerService.PutPassenger(id, passengerToAdd);
        }

        // DELETE api/<PassengersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           /* int index = Passengers.FindIndex((Passenger P) => { return P.Id == id; });
            Passengers.RemoveAt(index);*/
           _passengerService.DeletePassenger(id);
        }

    }
}
