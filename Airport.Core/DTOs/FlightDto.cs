using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Core.DTOs
{
    public class FlightDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime LeavingTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int TerminalNum { get; set; }
    }
}
