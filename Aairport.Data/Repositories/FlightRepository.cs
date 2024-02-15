using Airport.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace Aairport.Data.Repositories
{
    public class FlightRepository: IflightRepository
    {
        private readonly DataContext _context;
        public FlightRepository(DataContext context)
        {
            _context = context;
        }
        public List<Flight> GetList()
        {
            return _context.Flights;
        }
       public void PostFlight(Flight f)
        {
            _context.Flights.Add(f);
             
        }
        public void UpdateFlight(int id,Flight f)
        {
            _context.Flights[id] = f;
        }
        public void RemoveFlight(int index)
        {
            _context.Remove(_context.Flights[index]);
        }
    }
}
