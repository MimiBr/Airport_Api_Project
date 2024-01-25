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
    }
}
