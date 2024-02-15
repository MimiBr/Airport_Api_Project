using Airport.Core.Services;
using Airport.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengersController : ControllerBase
    {
        /* private static List<Passenger> Passengers = new List<Passenger>()
         {
            new Passenger{Id=1, Name="AVITAL",CountryOrigion="israel",distnationCountry="new york",NumBags=1},
              new Passenger{Id=2, Name="mimi",CountryOrigion="turkya",distnationCountry="budapest",NumBags=3}
          };
         private int CoundId = 3;*/


        private readonly IpassengerService _passengerService;
        public PassengersController(IpassengerService passengerService)
        {
            _passengerService = passengerService;
        }
        // GET: api/<PassengersController>
        [HttpGet]
        public IEnumerable<Passenger> Get()
        {
            return _passengerService.GettAll();
        }

        // GET api/<PassengersController>/5
        [HttpGet("{id}")]
        public Passenger Get(int id)
        {
           /* Passenger foundPassenger = Passengers.Find(x => x.Id == id);
            if (foundPassenger == null)
            {
                return null;
            }
            return foundPassenger;*/
           return _passengerService.GetById(id);
        }

        // POST api/<PassengersController>
        [HttpPost]
        public void Post([FromBody] Passenger P)
        {
           /* Passengers.Add(new Passenger { Id = CoundId,Name=P.Name,CountryOrigion=P.CountryOrigion,distnationCountry=P.distnationCountry,NumBags=P.NumBags });
            CoundId++;
            return Passengers[Passengers.Count - 1];*/
           _passengerService.PostNewPassenger(P);
        }

        // PUT api/<PassengersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Passenger P)
        {
          /*  int index = Passengers.FindIndex((Passenger P) => { return P.Id == id; });
            Passengers[index].Name = P.Name;
            Passengers[index].CountryOrigion = P.CountryOrigion;
            Passengers[index].distnationCountry = P.distnationCountry;
            Passengers[index].NumBags = P.NumBags;

            return P;*/
          _passengerService.PutPassenger(id, P);
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
