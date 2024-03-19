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

        public async Task<IEnumerable<Flight>> GettAllAsync()
        {
          return await _flightRepository.GetListAsync();
        }
        public async Task<Flight> GetByIdAsync(int Id)
        {
            var list =await _flightRepository.GetListAsync();
            Flight foundFlight = list.First(t => t.Id == Id);
            if (foundFlight == null)
            {
                return null;
            }
            return  foundFlight;
        }
        public async Task PostNewFlightAsync(Flight f)
        {
          await _flightRepository.PostFlightAsync(f);
            CountFlight++;

        }
        public async Task PutFlightAsync(int id,Flight f)
        {
             await _flightRepository.UpdateFlightAsync(id, f);

        }
        public async Task DeleteFlightAsync(int id)
        {
            var index= await GetByIdAsync(id);
            if(index != null)
            {
               await _flightRepository.RemoveFlightAsync(index);
            }
        }
            
    }
}
