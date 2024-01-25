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
    public class PassengersService:IpassengerService
    {
        private readonly IpassengerRepository _passengerRepository;
        public PassengersService(IpassengerRepository passengerRepository)
        {
            _passengerRepository = passengerRepository;
        }

        public List<Passenger> GettAll()
        {
            return _passengerRepository.GetList();
        }
    }
}
