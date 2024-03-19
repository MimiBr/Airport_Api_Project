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

        public async Task<IEnumerable<Passenger>> GettAllAsync()
        {
            return await _passengerRepository.GetListAsync();
        }
        public async Task<Passenger> GetByIdAsync(int Id)
        {
            var list = await _passengerRepository.GetListAsync();
            Passenger foundPassenger = list.First(t => t.Id == Id);
            if (foundPassenger == null)
            {
                return null;
            }
            return foundPassenger;
        }
        public async Task PostNewPassengerAsync(Passenger p)
        {
           await _passengerRepository.PostPassengerAsync(p);
            CoundId++;

        }
        public async Task PutPassengerAsync(int id, Passenger p)
        {
            await _passengerRepository.UpdatePassengerAsync(id, p);

        }

    
        public async Task DeletePassengerAsync(int Id)
        {
        var index = await GetByIdAsync(Id);
        if (index != null)
        {
            await _passengerRepository.RemovePassengerAsync(index);
        }
    }
    }

}
