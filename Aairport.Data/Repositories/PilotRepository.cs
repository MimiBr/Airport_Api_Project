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
            return _context.Pilots.ToList();
        }
        public async void PostPilotAsync(Pilot p)
        {
            _context.Pilots.Add(p);
          await  _context.SaveChangesAsync();


        }
        public async void UpdatePilotAsync(int index, Pilot p)
        {
            _context.Pilots.ToList()[index].Vettek = p.Vettek;
            _context.Pilots.ToList()[index].Name = p.Name;
            _context.Pilots.ToList()[index].NumWorker = p.NumWorker;
            _context.Pilots.ToList()[index].Company = p.Company;
          await  _context.SaveChangesAsync();

        }
        public async void RemovePilotAsync(int index)
        {
            _context.Pilots.Remove(_context.Pilots.ToList()[index]);
          await  _context.SaveChangesAsync();

        }
    }
}
