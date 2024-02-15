using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace Airport.Core.Repositories
{
    public interface IpilotRepository
    {
        List<Pilot> GetList();
        public void PostPilot(Pilot p);
        public void UpdatePilot(int index, Pilot p);

        public void RemovePilot(int index);
    }
}
