using Microsoft.EntityFrameworkCore;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace Aairport.Data
{
    public class DataContext :DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Pilot> Pilots { get; set; }
        /*  public DataContext()
          {
              Flights = new List<Flight>
              { new Flight { Id = 100, Date = new DateTime(), LeavingTime = new DateTime(), ArrivalTime = new DateTime(), TerminalNum = 50 }
              };
              Passengers = new List<Passenger>
              {
             new Passenger{Id=1, Name="AVITAL",CountryOrigion="israel",distnationCountry="new york",NumBags=1}
              };
              Pilots = new List<Pilot>
              {
              new Pilot{Id=1,Name="avi",NumWorker=10,Vettek=5,Company="el al"}
              };

          }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=airport_db");
        }


    }
}
