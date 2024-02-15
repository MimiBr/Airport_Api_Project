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
        private int countPassenger;
        private Passenger passenger;

        public int CoundId { get; private set; }

        public PassengersService(IpassengerRepository passengerRepository)
        {
            _passengerRepository = passengerRepository;
        }

        public List<Passenger> GettAll()
        {
            return _passengerRepository.GetList();
        }
        public Passenger GetById(int Id)
        {
            Passenger foundPassenger = _passengerRepository.GetList().Find(x => x.Id == Id);
            if (foundPassenger == null)
            {
                return null;
            }
            return foundPassenger;
        }
        public void PostNewPassenger(Passenger p)
        {
            _passengerRepository.PostPassenger(p);
            CoundId++;

        }
        public void PutPassenger(int id, Passenger p)
        {
            int index = _passengerRepository.GetList().FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _passengerRepository.UpdatePassenger(index, p);

              
            }

        }
        public void DeletePassenger(int id)
        {
            int index = _passengerRepository.GetList().FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _passengerRepository.RemovePassenger(index);
            }
        }
    }
}
