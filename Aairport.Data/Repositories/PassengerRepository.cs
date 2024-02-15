using Airport.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace Aairport.Data.Repositories
{
   
    public class PassengerRepository:IpassengerRepository
    {
        private readonly DataContext _context;
        public PassengerRepository(DataContext context)
        {
            _context = context;
        }
        public List<Passenger> GetList()
        {
            return _context.Passengers;
        }
        public void PostPassenger(Passenger p)
        {
            _context.Passengers.Add(p);

        }
        public void UpdatePassenger(int id, Passenger p)
        {
            _context.Passengers[id] = p;
        }
        public void RemovePassenger(int index)
        {
            _context.Remove(_context.Passengers[index]);
        }
    }
}
