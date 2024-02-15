using Airport.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace Aairport.Data.Repositories
{
    public class PilotRepository:IpilotRepository
    {
        private readonly DataContext _context;
        public PilotRepository(DataContext context)
        {
            _context = context;
        }
        public List<Pilot> GetList()
        {
            return _context.Pilots;
        }
        public void PostPilot(Pilot p)
        {
            _context.Pilots.Add(p);

        }
        public void UpdatePilot(int id, Pilot p)
        {
            _context.Pilots[id] = p;
        }
        public void RemovePilot(int index)
        {
            _context.Remove(_context.Pilots[index]);
        }
    }
}
