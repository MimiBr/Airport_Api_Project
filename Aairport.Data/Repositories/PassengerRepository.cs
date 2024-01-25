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
        private readonly DataContext _Context;
        public PassengerRepository(DataContext context)
        {
            _Context = context;
        }
        public List<Passenger> GetList()
        {
            return _Context.Passengers;
        }
    }
}
