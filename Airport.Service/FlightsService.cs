using Airport.Core.Repositories;
using Airport.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace Airport.Service
{
    public class FlightsService: IflightService
    {
        private readonly IflightRepository _flightRepository;
        private Flight flight;

        public int CountFlight { get; private set; }

        public FlightsService(IflightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public List<Flight> GettAll()
        {
          return _flightRepository.GetList();
        }
        public Flight GetById(int Id)
        {
            Flight foundFlight = _flightRepository.GetList().Find(x => x.Id == Id);
            if (foundFlight == null)
            {
                return null;
            }
            return foundFlight;
        }
        public void PostNewFlight(Flight f)
        {
            _flightRepository.PostFlight(f);
            CountFlight++;

        }
        public void PutFlight(int id,Flight f)
        {
            int index =_flightRepository.GetList().FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _flightRepository.UpdateFlight(id, flight);

               
            }

        }
        public void DeleteFlight(int id)
        {
            int index=_flightRepository.GetList().FindIndex(x => x.Id == id);
            if(index != -1)
            {
                _flightRepository.RemoveFlight(index);
            }
        }
            
    }
}
