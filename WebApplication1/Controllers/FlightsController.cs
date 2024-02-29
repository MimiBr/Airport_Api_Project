using Airport.Core.Services;
using Airport.Service;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        /*private static List<Flight> flightss = new List<Flight>()
        {
            new Flight{FlightsNum=100,Date=new DateTime(),LeavingTime=new DateTime(),ArrivalTime=new DateTime(),TerminalNum=50},
            new Flight{FlightsNum=101,Date=new DateTime(),LeavingTime=new DateTime(),ArrivalTime=new DateTime(),TerminalNum=52}

        };*/
        //private static int CountFlight = 102;

        private readonly IflightService _flightService;
        public FlightsController(IflightService flightService)
        {
            _flightService = flightService;
        }

        // GET: api/<FlightsController>
        [HttpGet]
        public IEnumerable<Flight> Get()
        {
            return _flightService.GettAll();
        }

        // GET api/<FlightsController>/5
        [HttpGet("{id}")]
        public Flight Get(int id)
        {
            /*  Flight foundFlight = flightss.Find(x => x.Id ==Id);
              if (foundFlight == null)
              {
                  return null;
              }
              return foundFlight;*/
          return _flightService.GetById(id);
        }

        // POST api/<FlightsController>
        [HttpPost]
        public void Post([FromBody] FlightPostModel f)
        {
           /* flightss.Add(new Flight {FlightsNum=CountFlight,Date=f.Date,LeavingTime=f.LeavingTime,ArrivalTime=f.ArrivalTime,TerminalNum=f.TerminalNum });
            CountFlight++;
            return flightss[flightss.Count - 1];*/
           var  flightToAdd=new Flight { Date = f.Date,LeavingTime=f.LeavingTime,ArrivalTime=f.ArrivalTime,TerminalNum=f.TerminalNum};
            _flightService.PostNewFlight(flightToAdd);
        }

        // PUT api/<FlightsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] FlightPostModel f)
        {
            /* int index = flightss.FindIndex((Flight P) => { return f.FlightsNum == FlightsNum; });
             flightss[index].Date= f.Date;
             flightss[index].LeavingTime= f.LeavingTime;
             flightss[index].ArrivalTime= f.ArrivalTime;
             flightss[index].TerminalNum= f.TerminalNum;
             return f;*/
            var flightToAdd = new Flight { Date = f.Date, LeavingTime = f.LeavingTime, ArrivalTime = f.ArrivalTime, TerminalNum = f.TerminalNum };

            _flightService.PutFlight(id, flightToAdd);

        }

        // DELETE api/<FlightsController>/5
        [HttpDelete("{id}")]
        public void Delete(int Id)
        {
           /* int index = flightss.FindIndex((Flight f) => { return f.FlightsNum == FlightsNum; });
            flightss.RemoveAt(index);*/
           _flightService.DeleteFlight(Id);
        }
    }
}
