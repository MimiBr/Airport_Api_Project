using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace Airport.Core.Services
{
    public interface IpassengerService
    {
        public Task<IEnumerable<Passenger>> GettAllAsync();
        public Task<Passenger> GetByIdAsync(int Id);
        public  Task PostNewPassengerAsync(Passenger p);
        public  Task PutPassengerAsync(int id, Passenger p);
        public  Task DeletePassengerAsync(int Id);

    }
}
