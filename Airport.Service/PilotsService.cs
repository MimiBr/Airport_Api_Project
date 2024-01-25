using Aairport.Data.Repositories;
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
    public class PilotsService:IpilotService
    {
        private readonly PilotRepository _pilotRepository;
        public PilotsService(PilotRepository pilotRepository)
        {
            _pilotRepository = pilotRepository;
        }

        public List<Pilot> GettAll()
        {
            return _pilotRepository.GetList();
        }
    }
}
