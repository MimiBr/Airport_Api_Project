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
        public void UpdateFlight(int index,Flight f)
        {
            _context.Flights[index].Date = f.Date;
            _context.Flights[index].ArrivalTime = f.ArrivalTime;
            _context.Flights[index].LeavingTime = f.LeavingTime;
            _context.Flights[index].TerminalNum = f.TerminalNum;
        }
        public void RemoveFlight(int index)
        {
            _context.Flights.Remove(_context.Flights[index]);
        }
    }
}
