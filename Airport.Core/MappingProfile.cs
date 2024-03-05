using Airport.Core.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace Airport.Core
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Flight, FlightDto>().ReverseMap();
            CreateMap<Passenger, PassengerDto>().ReverseMap();
            CreateMap<Pilot, PilotDto>().ReverseMap();

        }
    }
}
