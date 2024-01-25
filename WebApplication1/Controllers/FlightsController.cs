using Airport.Core.Services;
using Airport.Service;
using Microsoft.AspNetCore.Mvc;

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
        [HttpGet("{FlightsNum}")]
        public Flight Get(int FlightsNum)
        {
            Flight foundFlight = flightss.Find(x => x.FlightsNum ==FlightsNum);
            if (foundFlight == null)
            {
                return null;
            }
            return foundFlight;
        }

        // POST api/<FlightsController>
        [HttpPost]
        public Flight Post([FromBody] Flight f)
        {
            flightss.Add(new Flight {FlightsNum=CountFlight,Date=f.Date,LeavingTime=f.LeavingTime,ArrivalTime=f.ArrivalTime,TerminalNum=f.TerminalNum });
            CountFlight++;
            return flightss[flightss.Count - 1];
        }

        // PUT api/<FlightsController>/5
        [HttpPut("{id}")]
        public Flight Put(int FlightsNum, [FromBody] Flight f)
        {
            int index = flightss.FindIndex((Flight P) => { return f.FlightsNum == FlightsNum; });
            flightss[index].Date= f.Date;
            flightss[index].LeavingTime= f.LeavingTime;
            flightss[index].ArrivalTime= f.ArrivalTime;
            flightss[index].TerminalNum= f.TerminalNum;
            return f;

        }

        // DELETE api/<FlightsController>/5
        [HttpDelete("{id}")]
        public void Delete(int FlightsNum)
        {
            int index = flightss.FindIndex((Flight f) => { return f.FlightsNum == FlightsNum; });
            flightss.RemoveAt(index);
        }
    }
}
