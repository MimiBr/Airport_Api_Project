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
        public  Task<List<Flight>> GettAllAsync();
        public Task<Flight> GetByIdAsync(int Id);
        public  Task PostNewFlightAsync(Flight f);
        public Task PutFlightAsync(int id, Flight f);
        public Task DeleteFlightAsync(int id);
    }
}
