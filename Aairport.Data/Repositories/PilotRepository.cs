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
        private readonly DataContext _Context;
        public PilotRepository(DataContext context)
        {
            _Context = context;
        }
        public List<Pilot> GetList()
        {
            return _Context.Pilots;
        }
    }
}
