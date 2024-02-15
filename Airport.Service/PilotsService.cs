using Aairport.Data.Repositories;
using Airport.Core.Repositories;
using Airport.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace Airport.Service
{
    public class PilotsService:IpilotService
    {
        private readonly IpilotRepository _ipilotRepository;
        private int countId;
        private int CountID;
        private Pilot pilot;

        public PilotsService(IpilotRepository ipilotRepository)
        {
            _ipilotRepository = ipilotRepository;
        }

        public List<Pilot> GettAll()
        {
            return _ipilotRepository.GetList();
        }
        public Pilot GetById(int Id)
        {

            Pilot foundPilot = _ipilotRepository.GetList().Find(x => x.Id == Id);
            if (foundPilot == null)
            {
                return null;
            }
            return foundPilot;
        }
        public void PostNewPilot(Pilot p)
        {
            _ipilotRepository.PostPilot(p);
            CountID++;

        }
        public void PutPilot(int id, Pilot p)
        {
            int index = _ipilotRepository.GetList().FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _ipilotRepository.UpdatePilot(index, p);

           
            }
          

        }
        public void DeletePilot(int id)
        {
            int index = _ipilotRepository.GetList().FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _ipilotRepository.RemovePilot(index);
            }
        }
    }
}
