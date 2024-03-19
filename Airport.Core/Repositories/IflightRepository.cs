using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace Airport.Core.Repositories
{
    public interface IflightRepository
    {
        public Task<IEnumerable<Flight>> GetListAsync();
        public  Task PostFlightAsync(Flight f);
        public  Task UpdateFlightAsync(int index, Flight f);
        public  Task RemoveFlightAsync(Flight flight);
    }
}
