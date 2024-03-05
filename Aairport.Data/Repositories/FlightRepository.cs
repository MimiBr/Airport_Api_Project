using Airport.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace Aairport.Data.Repositories
{
    public class FlightRepository : IflightRepository
    {
        private readonly DataContext _context;
        public FlightRepository(DataContext context)
        {
            _context = context;
        }
        public List<Flight> GetList()
        {
            return _context.Flights.Include((p) => p.Passengers).ToList();
        }
        public async void PostFlightAsync(Flight f)
        {
            _context.Flights.Add(f);
           await _context.SaveChangesAsync();

        }
        public async void UpdateFlightAsync(int index, Flight f)
        {
            _context.Flights.ToList()[index].Date = f.Date;
            _context.Flights.ToList()[index].ArrivalTime = f.ArrivalTime;
            _context.Flights.ToList()[index].LeavingTime = f.LeavingTime;
            _context.Flights.ToList()[index].TerminalNum = f.TerminalNum;
          await  _context.SaveChangesAsync();

        }
        public async void RemoveFlightAsync(Flight flight)
        {
            _context.Flights.Remove(flight);
           await _context.SaveChangesAsync();


        }
    }
}
