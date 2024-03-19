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
        public async Task<IEnumerable<Flight>> GetListAsync()
        {
            return await _context.Flights.Include((p) => p.Passengers).ToListAsync();
        }
        public async Task PostFlightAsync(Flight f)
        {
            _context.Flights.Add(f);
           await _context.SaveChangesAsync();

        }
        public async Task UpdateFlightAsync(int id, Flight f)
        {
            var list = await _context.Flights.ToListAsync();
            Flight foundFlight=list.Find((s)=>s.Id==id);
            if (foundFlight != null) {
               foundFlight.ArrivalTime=f.ArrivalTime;
                foundFlight.TerminalNum=f.TerminalNum;
                foundFlight.LeavingTime=f.LeavingTime;
                foundFlight.Date=f.Date;
          await  _context.SaveChangesAsync();
            }
        }
        public async Task RemoveFlightAsync(Flight flight)
        {
            _context.Flights.Remove(flight);
           await _context.SaveChangesAsync();
        }
    }
}
