using Airport.Core.Repositories;
using Microsoft.EntityFrameworkCore;
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
        private readonly DataContext _context;
        public PassengerRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Passenger>> GetListAsync()
        {
            return await _context.Passengers.Include(p => p.flight).ToListAsync();  
        }
        public async Task PostPassengerAsync(Passenger p)
        {
            _context.Passengers.Add(p);
         await  _context.SaveChangesAsync();


        }
        public async Task UpdatePassengerAsync(int index, Passenger p)
        {
            var list = await _context.Passengers.ToListAsync();
            Passenger foundPassenger = list.Find((s) => s.Id == index);
            if(foundPassenger != null) { 
            foundPassenger.distnationCountry= p.distnationCountry;
            foundPassenger.CountryOrigion= p.CountryOrigion;
            foundPassenger.NumBags= p.NumBags;
            foundPassenger.Name= p.Name;
          await _context.SaveChangesAsync();
            }

        }
        public async Task RemovePassengerAsync(Passenger index)
        {
            _context.Passengers.Remove(index);
          await _context.SaveChangesAsync();

        }
    }
}
