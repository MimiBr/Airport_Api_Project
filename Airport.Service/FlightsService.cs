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
        public FlightsService(IflightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public List<Flight> GettAll()
        {
          return _flightRepository.GetList();
        }
    }
}
