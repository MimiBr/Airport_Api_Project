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
        public void PostPassenger(Passenger p);
        public void UpdatePassenger(int id, Passenger p);
        public void RemovePassenger(int index);
    }
}
