using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace Airport.Core.Services
{
    public interface IpassengerService
    {
       public List<Passenger> GettAll();
        Passenger GetById(int Id);
        public void PostNewPassenger(Passenger p);
        public void PutPassenger(int id, Passenger p);
        public void DeletePassenger(int id);

    }
}
