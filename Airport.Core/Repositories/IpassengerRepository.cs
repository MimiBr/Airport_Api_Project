using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace Airport.Core.Repositories
{
    public interface IpassengerRepository
    {
        public Task<IEnumerable<Passenger>> GetListAsync();
        public  Task PostPassengerAsync(Passenger p);
        public  Task UpdatePassengerAsync(int index, Passenger p);
        public  Task RemovePassengerAsync(Passenger index);
    }
}
