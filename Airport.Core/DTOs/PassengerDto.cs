using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Core.DTOs
{
    public class PassengerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryOrigion { get; set; }
        public string distnationCountry { get; set; }
        public int NumBags { get; set; }
        public int IdFlight { get; set; }
        public FlightDto flight { get; set; }
    }
}
