﻿namespace WebApplication1
{
    public class Passenger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryOrigion { get; set; }
        public string distnationCountry { get; set; }
        public int NumBags { get; set; }
        public int IdFlight { get; set; }
      //יחיד לרבים
      public  Flight flight { get; set; }
}
}
