using Airport.Core.Services;
using Airport.Service;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PilotsController : ControllerBase
    {
        /*private static List<Pilot> Pilots = new List<Pilot>()
        {
            new Pilot{Id=1,Name="avi",NumWorker=10,Vettek=5,Company="el al"},
            new Pilot{Id=2,Name="dani",NumWorker=11,Vettek=6,Company="arkia"},
            new Pilot{Id=3,Name="shimi",NumWorker=12,Vettek=7,Company="mmm"}
         };
        private static int CountID = 4;*/

        private readonly IpilotService _pilotService;
        public PilotsController(IpilotService pilotsService)
        {
            _pilotService = pilotsService;
        }
        // GET: api/<PilotController>
        [HttpGet]
        public IEnumerable<Pilot> Get()
        {
            return _pilotService.GettAll();
        }

        // GET api/<PilotController>/5
        [HttpGet("{id}")]
        public Pilot Get(int id)
        {
         /*   Pilot foundPILOT=Pilots.Find(x => x.Id==id);
            if (foundPILOT == null)
            {
                return null;
            }
            return foundPILOT;*/
         return _pilotService.GetById(id);
        }

        // POST api/<PilotController>
        [HttpPost]
        public void Post([FromBody] PilotPostModel p)
        {
         /*   Pilots.Add(new Pilot { Id = CountID, Name = p.Name, NumWorker = p.NumWorker, Vettek = p.Vettek, Company = p.Company });
            CountID++;
            return Pilots[Pilots.Count - 1];*/
         var pilotToAdd=new Pilot { Name=p.Name,NumWorker=p.NumWorker,Vettek=p.Vettek,Company=p.Company};
         _pilotService.PostNewPilot(pilotToAdd);
        }

        // PUT api/<PilotController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PilotPostModel p)
        {
            /*int index = Pilots.FindIndex((Pilot P) => { return P.Id == id; });
            Pilots[index].Name= PP.Name;
            Pilots[index].NumWorker= PP.NumWorker;
            Pilots[index].Vettek= PP.Vettek;
            Pilots[index].Company= PP.Company;
            return PP;*/
            var pilotToAdd = new Pilot { Name = p.Name, NumWorker = p.NumWorker, Vettek = p.Vettek, Company = p.Company };

            _pilotService.PutPilot(id, pilotToAdd);
        }

        // DELETE api/<PilotController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            /*int index = Pilots.FindIndex((Pilot P) => { return P.Id == id; });
            Pilots.RemoveAt(index);*/
            _pilotService.DeletePilot(id);

        }
    }
}
