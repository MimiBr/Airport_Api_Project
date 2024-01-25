using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace Aairport.Data
{
    public class DataContext
    {
        public List<Flight> Flights { get; set; }
        public List<Passenger> Passengers { get; set; }
        public List<Pilot> Pilots { get; set; }
        public DataContext()
        {
            Flights = new List<Flight>
            { new Flight { FlightsNum = 100, Date = new DateTime(), LeavingTime = new DateTime(), ArrivalTime = new DateTime(), TerminalNum = 50 }
            };
            Passengers = new List<Passenger>
            {
           new Passenger{Id=1, Name="AVITAL",CountryOrigion="israel",distnationCountry="new york",NumBags=1}
            };
            Pilots = new List<Pilot>
            {
            new Pilot{Id=1,Name="avi",NumWorker=10,Vettek=5,Company="el al"}
            };

        }

    }
}
