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
        List<Passenger> GetList();
        public void PostPassengerAsync(Passenger p);
        public void UpdatePassengerAsync(int index, Passenger p);
        public void RemovePassengerAsync(int index);
    }
}
