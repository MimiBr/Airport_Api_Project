using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace Airport.Core.Services
{
    public interface IflightService
    {
       public List<Flight> GettAll();
        Flight GetById(int Id);
        public void PostFlight(Flight f);
        public void PutFlight(int id, Flight f);
        public void DeleteFlight(int Id);
    }
}
