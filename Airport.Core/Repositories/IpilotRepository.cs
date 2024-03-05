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
        public void PostPilotAsync(Pilot p);
        public void UpdatePilotAsync(int index, Pilot p);

        public void RemovePilotAsync(int index);
    }
}
