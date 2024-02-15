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
        public void UpdatePassenger(int index, Passenger p)
        {
            _context.Passengers[index].Name= p.Name;
            _context.Passengers[index].NumBags = p.NumBags;
            _context.Passengers[index].CountryOrigion = p.CountryOrigion;
            _context.Passengers[index].distnationCountry = p.distnationCountry;

        }
        public void RemovePassenger(int index)
        {
            _context.Passengers.Remove(_context.Passengers[index]);
        }
    }
}
