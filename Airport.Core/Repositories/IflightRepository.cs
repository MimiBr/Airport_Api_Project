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
      public List<Flight> GetList();
        public void PostFlightAsync(Flight f);
        public void UpdateFlightAsync(int index, Flight f);
        public void RemoveFlightAsync(Flight flight);
    }
}
