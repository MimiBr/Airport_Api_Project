namespace WebApplication1
{
    public class Flight
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime LeavingTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int TerminalNum { get; set; }
        //many to one
        public List<Passenger> Passengers { get; set; }
        public List<Pilot> Pilots { get; set; }
        //many to many

    }
}
